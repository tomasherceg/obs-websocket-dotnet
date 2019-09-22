using System;
using System.Collections.Generic;

namespace ObsWebsocketModels
{
    public class ClientStatus
    {

        public bool IsConnected { get; set; }

        public bool IsStreaming { get; set; }

        public bool IsRecording { get; set; }

        public List<string> Scenes { get; set; }

        public string ActiveScene { get; set; }

    }
}
