using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using ObsWebsocketModels;

namespace ObsWebsocketDashboard.Services
{
    public class ClientStatusRepository
    {
        private readonly string cacheDirectory;

        public ClientStatusRepository(IWebHostEnvironment env)
        {
            this.cacheDirectory = Path.Combine(env.ContentRootPath, "App_Data\\StatusCache");
            if (!Directory.Exists(cacheDirectory))
            {
                Directory.CreateDirectory(cacheDirectory);
            }
        }

        public async Task<ClientStatus> LoadState(Guid clientId)
        {
            var filePath = GetFilePath(clientId);
            if (File.Exists(filePath))
            {
                return JsonConvert.DeserializeObject<ClientStatus>(await File.ReadAllTextAsync(filePath));
            }
            else
            {
                return null;
            }
        }

        public async Task SaveState(Guid clientId, ClientStatus status)
        {
            await File.WriteAllTextAsync(GetFilePath(clientId), JsonConvert.SerializeObject(status));
        }

        private string GetFilePath(Guid clientId)
        {
            return Path.Combine(cacheDirectory, clientId.ToString() + ".json");
        }
    }
}
