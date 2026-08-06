using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using VmixMouseTracker.Properties;
using Timer = System.Threading.Timer;

namespace VmixMouseTracker
{
    public class MouseTrackingService : IDisposable
    {
        private const int DebounceSeconds = 1;
        private const int FadeDurationMs = 500;

        private readonly Timer timer;
        private readonly HttpClient httpClient;

        private bool lastStateInArea = false;
        private DateTime lastStateChange = DateTime.MinValue;
        private bool? lastAppliedStateInArea = null;
        private bool isSwitching = false;

        public MouseTrackingService()
        {
            httpClient = new HttpClient();
            timer = new Timer(OnTick, null, 500, 500);
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

            if (lastStateChange.AddSeconds(DebounceSeconds) < DateTime.Now)
            {
                if (lastAppliedStateInArea != inArea)
                {
                    lastAppliedStateInArea = inArea;
                    TrySwitchScene(inArea);
                }
            }
        }

        private async void TrySwitchScene(bool inArea)
        {
            if (!Settings.Default.IsEnabled) return;

            // avoid overlapping requests if ticks fire while a previous check/switch is still in flight
            if (isSwitching) return;
            isSwitching = true;

            try
            {
                var expectedCurrentInputName = inArea ? Settings.Default.ComboInputName : Settings.Default.ScreenOnlyInputName;
                var targetInputName = inArea ? Settings.Default.ScreenOnlyInputName : Settings.Default.ComboInputName;

                var activeInputName = await GetActiveInputNameAsync();

                // only switch if the current active input is the one we expect; otherwise leave vMix alone
                if (!string.Equals(activeInputName, expectedCurrentInputName, StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }

                await ChangeSceneAsync(targetInputName);
            }
            catch (Exception)
            {
                Console.WriteLine("Vmix: Cannot check/change scene. Message send failure.");
            }
            finally
            {
                isSwitching = false;
            }
        }

        private async Task<string> GetActiveInputNameAsync()
        {
            var baseUrl = (Settings.Default.VmixApiBaseUrl ?? "").TrimEnd('/');
            var url = $"{baseUrl}/api/";

            var xml = await httpClient.GetStringAsync(url);
            var doc = XDocument.Parse(xml);

            var activeNumber = (string)doc.Root?.Element("active");
            if (string.IsNullOrEmpty(activeNumber)) return null;

            var activeInput = doc.Root?.Element("inputs")?.Elements("input")
                .FirstOrDefault(i => (string)i.Attribute("number") == activeNumber);

            return (string)activeInput?.Attribute("title");
        }

        private async Task ChangeSceneAsync(string inputName)
        {
            var baseUrl = (Settings.Default.VmixApiBaseUrl ?? "").TrimEnd('/');
            var url = $"{baseUrl}/api/?Function=Fade&Duration={FadeDurationMs}&Input={Uri.EscapeDataString(inputName)}";

            await httpClient.GetAsync(url);
        }

        public void Dispose()
        {
            timer?.Dispose();
            httpClient?.Dispose();
        }
    }
}

