using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using ObsWebsocketDashboard.Services;
using ObsWebsocketModels;

namespace ObsWebsocketDashboard.Hubs
{
    public class ObsHub : Hub
    {
        private readonly ClientStatusRepository clientStatusRepository;

        public ObsHub(ClientStatusRepository clientStatusRepository)
        {
            this.clientStatusRepository = clientStatusRepository;
        }

        public async Task StatusChanged(Guid clientId, ClientStatus status)
        {
            await clientStatusRepository.SaveState(clientId, status);

            await Clients.Others.SendCoreAsync(nameof(StatusChanged), new object[] { clientId, status });
        }

        public async Task GetLastStatus(Guid clientId)
        {
            var status = await clientStatusRepository.LoadState(clientId);

            await Clients.Caller.SendCoreAsync(nameof(StatusChanged), new object[] { clientId, status });
        }

        public async Task SwitchScene(Guid clientId, string sceneName)
        {
            await Clients.Others.SendCoreAsync(nameof(SwitchScene), new object[] { clientId, sceneName });
        }

        public async Task ChangeRecordingState(Guid clientId, bool enabled)
        {
            await Clients.Others.SendCoreAsync(nameof(ChangeRecordingState), new object[] { clientId, enabled });
        }

        public async Task ChangeStreamingState(Guid clientId, bool enabled)
        {
            await Clients.Others.SendCoreAsync(nameof(ChangeStreamingState), new object[] { clientId, enabled });
        }

    }
}