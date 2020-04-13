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
                .WithUrl(ConfigurationManager.AppSettings["Hub:Url"], options =>
                {
                    options.AccessTokenProvider = () => Task.FromResult(clientId.ToString());
                })
                .WithAutomaticReconnect()
                .Build();
            hubConnection.On<string>("SwitchScene", OnSwitchScene);
            hubConnection.On<bool>("ChangeRecordingState", OnChangeRecordingState);
            hubConnection.On<bool>("ChangeStreamingState", OnChangeStreamingState);
            hubConnection.Reconnecting += OnHubConnectionReconnecting;
            hubConnection.Reconnected += OnHubConnectionReconnected;
            hubConnection.Closed += OnHubConnectionClosed;
            await TryConnect();

            // init OBS connection
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

        private static void OnChangeStreamingState(bool enabled)
        {
            obsConnection.ChangeStreamingState(enabled);
        }

        private static void OnChangeRecordingState(bool enabled)
        {
            obsConnection.ChangeRecordingState(enabled);
        }

        private static void OnSwitchScene(string scene)
        {
            obsConnection.SwitchScene(scene);
        }

        private static void OnStatusChanged(ClientStatus status)
        {
            try
            {
                hubConnection.InvokeAsync("StatusChanged", status);
            }
            catch (Exception)
            {
                Console.WriteLine("HUB: Message send failure.");
            }
        }

        private static Task OnHubConnectionClosed(Exception error)
        {
            Console.WriteLine("Hub: Disconnected, will retry.");
            return Task.CompletedTask;
        }

        private static Task OnHubConnectionReconnected(string arg)
        {
            Console.WriteLine("Hub: Reconnected.");
            return Task.CompletedTask;
        }

        private static Task OnHubConnectionReconnecting(Exception arg)
        {
            Console.WriteLine("Hub: Reconnecting...");
            return Task.CompletedTask;
        }


    }
}
