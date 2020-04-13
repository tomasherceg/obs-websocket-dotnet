using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ObsMouseTracker.Properties;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using ObsWebsocketModels;
using Timer = System.Threading.Timer;

namespace ObsMouseTracker
{
    public class MouseTrackingService : IDisposable
    {
        private readonly Timer timer;
        private readonly HubConnection hubConnection;
        private readonly Guid clientId;
        private readonly object locker = new object();

        private bool lastStateInArea = false;
        private DateTime lastStateChange = DateTime.MinValue;
        private string currentScene = "";

        private string CurrentScene
        {
            get
            {
                lock (locker)
                {
                    return currentScene;
                }
            }
            set
            {
                lock (locker)
                {
                    currentScene = value;
                }
            }
        }

        public MouseTrackingService()
        {
            timer = new Timer(OnTick, null, 500, 500);

            clientId = new Guid(ConfigurationManager.AppSettings["Hub:ClientId"]);

            // init SignalR
            hubConnection = new HubConnectionBuilder()
                .WithUrl(ConfigurationManager.AppSettings["Hub:Url"])
                .Build();
            hubConnection.On<Guid, ClientStatus>("StatusChanged", (id, status) => CurrentScene = status.ActiveScene);
            hubConnection.Closed += OnHubConnectionClosed;
            Task.Run(TryConnect);
        }

        private void OnTick(object state)
        {
            var position = Cursor.Position;
            var inArea = (Settings.Default.Area_X <= position.X && position.X <= Settings.Default.Area_X + Settings.Default.Area_Width)
                         && (Settings.Default.Area_Y <= position.Y && position.Y <= Settings.Default.Area_Y + Settings.Default.Area_Height);

            if (inArea != lastStateInArea)
            {
                lastStateChange = DateTime.Now;
                lastStateInArea = inArea;
            }

            if (lastStateChange.AddSeconds(2) < DateTime.Now)
            {
                if (inArea && CurrentScene == Settings.Default.ComboSceneName)
                {
                    ChangeScene(Settings.Default.ScreenOnlySceneName);
                }
                else if (!inArea && CurrentScene == Settings.Default.ScreenOnlySceneName)
                {
                    ChangeScene(Settings.Default.ComboSceneName);
                }
            }
        }

        private void ChangeScene(string sceneName)
        {
            try
            {
                hubConnection.InvokeAsync("SwitchScene", clientId, sceneName);
            }
            catch (Exception)
            {
                Console.WriteLine("HUB: Message send failure.");
            }
        }

        public void Dispose()
        {
            timer?.Dispose();
        }

        private async Task TryConnect()
        {
            retry:
            try
            {
                await hubConnection.StartAsync();
                Console.WriteLine("Hub: Connected");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hub: Disconnected, will retry in 5 seconds. " + ex.Message);
                await Task.Delay(5000);
                goto retry;
            }
        }

        private async Task OnHubConnectionClosed(Exception error)
        {
            Console.WriteLine("Hub: Disconnected, will retry in 5 seconds.");
            await Task.Delay(5000);
            await TryConnect();
        }

    }
}
