using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OBSWebsocketDotNet;
using OBSWebsocketDotNet.Types;
using ObsWebsocketModels;

namespace ObsWebsocketProxy
{
    public class ObsConnection : IDisposable
    {
        private readonly string url;
        private readonly string password;
        private OBSWebsocket obs;
        private static object locker = new object();

        public event Action<ClientStatus> StatusChanged;

        public ObsConnection(string url, string password)
        {
            this.url = url;
            this.password = password;
        }

        public void Start()
        {
            if (obs != null)
            {
                throw new InvalidOperationException();
            }

            obs = new OBSWebsocket();
            obs.Connected += OnConnect;
            obs.Disconnected += OnDisconnect;
            obs.SceneChanged += OnSceneChange;
            obs.StreamingStateChanged += OnStreamingStateChange;
            obs.RecordingStateChanged += OnRecordingStateChange;
            
            TryConnect();
        }
        

        private void TryConnect()
        {
            retry:
            try
            {
                obs.Connect(url, password);
                Console.WriteLine("OBS: Connected.");
                ReportStatusChanged();
            }
            catch (AuthFailureException)
            {
                Console.WriteLine("OBS: Authentication failed.");
                Environment.Exit(1);
            }
            catch (ErrorResponseException ex)
            {
                Console.WriteLine("OBS: Connect failed: " + ex.Message);
                Console.WriteLine("OBS: Will retry in 5 seconds...");
                Thread.Sleep(5000);
                goto retry;
            }
        }

        private void OnConnect(object sender, EventArgs e)
        {
            Console.WriteLine("OBS: Connected");
        }

        private void OnDisconnect(object sender, EventArgs e)
        {
            Console.WriteLine("OBS: Disconnected");
            Console.WriteLine("OBS: Will retry in 5 seconds...");
            Thread.Sleep(5000);
            TryConnect();
        }

        public void Dispose()
        {
            try
            {
                obs.Disconnect();
            }
            catch (Exception)
            {
                // this is intentional, the app is exiting
            }
        }

        private void OnSceneChange(OBSWebsocket sender, string newSceneName)
        {
            Console.WriteLine($"OBS: Scene changed to {newSceneName}");
            ReportStatusChanged();
        }

        private void OnStreamingStateChange(OBSWebsocket sender, OutputState type)
        {
            Console.WriteLine($"OBS: Streaming {type}");
            ReportStatusChanged();
        }

        private void OnRecordingStateChange(OBSWebsocket sender, OutputState type)
        {
            Console.WriteLine($"OBS: Recording {type}");
            ReportStatusChanged();
        }

        private void ReportStatusChanged()
        {
            Task.Factory.StartNew(() =>
            {
                ClientStatus status;
                lock (locker)
                {
                    if (obs.IsConnected)
                    {
                        var streamingStatus = obs.GetStreamingStatus();
                        status = new ClientStatus()
                        {
                            IsConnected = true,
                            Scenes = obs.ListScenes().Select(s => s.Name).ToList(),
                            ActiveScene = obs.GetCurrentScene().Name,
                            IsStreaming = streamingStatus.IsStreaming,
                            IsRecording = streamingStatus.IsRecording
                        };
                    }
                    else
                    {
                        status = new ClientStatus()
                        {
                            IsConnected = false
                        };
                    }
                }

                StatusChanged?.Invoke(status);
            });
        }

        public void SwitchScene(string scene)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    lock (locker)
                    {
                        obs.SetCurrentScene(scene);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("OBS: Error sending command. " + ex.Message);
                }
            });
        }

        public void ChangeRecordingState(bool enabled)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    lock (locker)
                    {
                        if (enabled)
                        {
                            obs.StartRecording();
                        }
                        else
                        {
                            obs.StopRecording();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("OBS: Error sending command. " + ex.Message);
                }
            });
        }

        public void ChangeStreamingState(bool enabled)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    lock (locker)
                    {
                        if (enabled)
                        {
                            obs.StartStreaming();
                        }
                        else
                        {
                            obs.StopStreaming();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("OBS: Error sending command. " + ex.Message);
                }
            });
        }
    }
}
