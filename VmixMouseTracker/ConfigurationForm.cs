using System;
using System.Linq;
using System.Windows.Forms;
using VmixMouseTracker.Properties;

namespace VmixMouseTracker
{
    public partial class ConfigurationForm : Form
    {
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            AreaTextBox.Text = string.Join(";", new[] { Settings.Default.Area_X, Settings.Default.Area_Y, Settings.Default.Area_Width, Settings.Default.Area_Height });
            ComboInputNameTextBox.Text = Settings.Default.ComboInputName;
            ScreenOnlyInputNameTextBox.Text = Settings.Default.ScreenOnlyInputName;
            VmixApiBaseUrlTextBox.Text = Settings.Default.VmixApiBaseUrl;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var area = AreaTextBox.Text.Split(';').Select(int.Parse).ToArray();
            Settings.Default.Area_X = area[0];
            Settings.Default.Area_Y = area[1];
            Settings.Default.Area_Width = area[2];
            Settings.Default.Area_Height = area[3];

            Settings.Default.ComboInputName = ComboInputNameTextBox.Text.Trim();
            Settings.Default.ScreenOnlyInputName = ScreenOnlyInputNameTextBox.Text.Trim();
            Settings.Default.VmixApiBaseUrl = VmixApiBaseUrlTextBox.Text.Trim();

            Settings.Default.Save();
            Close();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            using (var f = new AreaSelectionForm())
            {
                f.Move += (s, a) => SavePosition(f);
                f.Resize += (s, a) => SavePosition(f);
                f.ShowDialog();
            }
        }

        private void SavePosition(AreaSelectionForm f)
        {
            AreaTextBox.Text = $"{f.Left};{f.Top};{f.Width};{f.Height}";
        }
    }
}
