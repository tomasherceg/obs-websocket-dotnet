using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OBSWebsocketDotNet;
using OBSWebsocketDotNet.Communication;
using OBSWebsocketDotNet.Types;
using OBSWebsocketDotNet.Types.Events;
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
            obs.CurrentProgramSceneChanged += OnSceneChange;
            obs.StreamStateChanged += OnStreamingStateChange;
            obs.RecordStateChanged += OnRecordingStateChange;
            
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

        private void OnDisconnect(object sender, ObsDisconnectionInfo e)
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

        private void OnSceneChange(object sender, ProgramSceneChangedEventArgs args)
        {
            Console.WriteLine($"OBS: Scene changed to {args.SceneName}");
            ReportStatusChanged();
        }

        private void OnStreamingStateChange(object sender, StreamStateChangedEventArgs args)
        {
            Console.WriteLine($"OBS: Streaming {args.OutputState.State}");
            ReportStatusChanged();
        }

        private void OnRecordingStateChange(object sender, RecordStateChangedEventArgs args)
        {
            Console.WriteLine($"OBS: Recording {args.OutputState.State}");
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
                        var streamingStatus = obs.GetStreamStatus();
                        var recordingStatus = obs.GetRecordStatus();
                        status = new ClientStatus()
                        {
                            IsConnected = true,
                            Scenes = obs.ListScenes().Select(s => s.Name).ToList(),
                            ActiveScene = obs.GetCurrentProgramScene(),
                            IsStreaming = streamingStatus.IsActive,
                            IsRecording = recordingStatus.IsRecording
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
                        obs.SetCurrentProgramScene(scene);
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
                            obs.StartRecord();
                        }
                        else
                        {
                            obs.StopRecord();
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
                            obs.StartStream();
                        }
                        else
                        {
                            obs.StopStream();
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
