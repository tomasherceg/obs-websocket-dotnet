using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using ObsWebsocketDashboard.Services;
using ObsWebsocketModels;

namespace ObsWebsocketDashboard.Hubs
{
    [Authorize]
    public class ObsHub : Hub
    {
        private readonly ClientStatusRepository clientStatusRepository;

        public ObsHub(ClientStatusRepository clientStatusRepository)
        {
            this.clientStatusRepository = clientStatusRepository;
        }

        private string GroupName => ClientId.ToString().ToLower();

        private Guid ClientId => new Guid(Context.User.FindFirstValue(ClaimTypes.Name));


        public override async Task OnConnectedAsync()
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, GroupName);
            await base.OnConnectedAsync();
        }

        public async Task StatusChanged(ClientStatus status)
        {
            await clientStatusRepository.SaveState(ClientId, status);

            await Clients.GroupExcept(GroupName, Context.ConnectionId)
                .SendCoreAsync(nameof(StatusChanged), new object[] { status });
        }

        public async Task GetLastStatus()
        {
            var status = await clientStatusRepository.LoadState(ClientId);

            await Clients.Caller
                .SendCoreAsync(nameof(StatusChanged), new object[] { status });
        }

        public async Task SwitchScene(string sceneName)
        {
            await Clients.GroupExcept(GroupName, Context.ConnectionId)
                .SendCoreAsync(nameof(SwitchScene), new object[] { sceneName });
        }

        public async Task ChangeRecordingState(bool enabled)
        {
            await Clients.GroupExcept(GroupName, Context.ConnectionId)
                .SendCoreAsync(nameof(ChangeRecordingState), new object[] { enabled });
        }

        public async Task ChangeStreamingState(bool enabled)
        {
            await Clients.GroupExcept(GroupName, Context.ConnectionId)
                .SendCoreAsync(nameof(ChangeStreamingState), new object[] { enabled });
        }

    }
}