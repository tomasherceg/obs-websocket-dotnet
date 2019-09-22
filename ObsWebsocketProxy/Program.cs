using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using OBSWebsocketDotNet;
using OBSWebsocketDotNet.Types;
using ObsWebsocketModels;

namespace ObsWebsocketProxy
{
    class Program
    {
        private static ObsConnection obsConnection;
        private static HubConnection hubConnection;
        private static Guid clientId;

        static async Task Main(string[] args)
        {
            clientId = new Guid(ConfigurationManager.AppSettings["Hub:ClientId"]);

            // init SignalR
            hubConnection = new HubConnectionBuilder()
                .WithUrl(ConfigurationManager.AppSettings["Hub:Url"])
                .Build();
            hubConnection.On<Guid, string>("SwitchScene", OnSwitchScene);
            hubConnection.On<Guid, bool>("ChangeRecordingState", OnChangeRecordingState);
            hubConnection.On<Guid, bool>("ChangeStreamingState", OnChangeStreamingState);
            hubConnection.Closed += OnHubConnectionClosed;
            await TryConnect();

            // init OBC connection
            obsConnection = new ObsConnection(ConfigurationManager.AppSettings["OBS:WebsocketUrl"], ConfigurationManager.AppSettings["OBS:Password"]);
            obsConnection.StatusChanged += OnStatusChanged;
            obsConnection.Start();

            // wait
            while (true)
            {
                await Task.Delay(200);
            }
        }

        private static async Task TryConnect()
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

        private static void OnChangeStreamingState(Guid remoteClientId, bool enabled)
        {
            if (remoteClientId == clientId)
            {
                obsConnection.ChangeStreamingState(enabled);
            }
        }

        private static void OnChangeRecordingState(Guid remoteClientId, bool enabled)
        {
            if (remoteClientId == clientId)
            {
                obsConnection.ChangeRecordingState(enabled);
            }
        }

        private static void OnSwitchScene(Guid remoteClientId, string scene)
        {
            if (remoteClientId == clientId)
            {
                obsConnection.SwitchScene(scene);
            }
        }

        private static void OnStatusChanged(ClientStatus status)
        {
            try
            {
                hubConnection.InvokeAsync("StatusChanged", clientId, status);
            }
            catch (Exception)
            {
                Console.WriteLine("HUB: Message send failure.");
            }
        }

        private static async Task OnHubConnectionClosed(Exception error)
        {
            Console.WriteLine("Hub: Disconnected, will retry in 5 seconds.");
            await Task.Delay(5000);
            await TryConnect();
        }

    }
}
