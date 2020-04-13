using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObsMouseTracker.Properties;

namespace ObsMouseTracker
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
            ComboSceneNameTextBox.Text = Settings.Default.ComboSceneName;
            ScreenOnlySceneTextBox.Text = Settings.Default.ScreenOnlySceneName;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var area = AreaTextBox.Text.Split(';').Select(int.Parse).ToArray();
            Settings.Default.Area_X = area[0];
            Settings.Default.Area_Y = area[1];
            Settings.Default.Area_Width = area[2];
            Settings.Default.Area_Height = area[3];
            
            Settings.Default.ComboSceneName = ComboSceneNameTextBox.Text.Trim();
            Settings.Default.ScreenOnlySceneName = ScreenOnlySceneTextBox.Text.Trim();
            
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
