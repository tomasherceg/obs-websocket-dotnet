using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ObsMouseTracker.Properties;

namespace ObsMouseTracker
{
    public class ObsMouseTrackerAppContext : ApplicationContext
    {
        private readonly NotifyIcon trayIcon;
        private readonly ContextMenuStrip contextMenu;
        private readonly MouseTrackingService mouseTrackingService;

        private readonly ToolStripMenuItem enabledMenuItem;
        private readonly ToolStripMenuItem settingsMenuItem;
        private readonly ToolStripMenuItem exitMenuItem;

        public ObsMouseTrackerAppContext()
        {
            // build context menu
            contextMenu = new ContextMenuStrip();
            enabledMenuItem = new ToolStripMenuItem("Enabled", null, ToggleEnabled)
            {
                Checked = Settings.Default.IsEnabled
            };
            settingsMenuItem = new ToolStripMenuItem("Settings", null, ShowSettings);
            exitMenuItem = new ToolStripMenuItem("Exit", null, Exit);

            contextMenu.Items.Add(enabledMenuItem);
            contextMenu.Items.Add(settingsMenuItem);
            contextMenu.Items.Add(new ToolStripSeparator());
            contextMenu.Items.Add(exitMenuItem);

            // initialize tray icon
            trayIcon = new NotifyIcon()
            {
                Icon = Resources.AppIcon,
                ContextMenuStrip = contextMenu,
                Visible = true
            };

            // start mouse tracking
            mouseTrackingService = new MouseTrackingService();
        }

        private void ToggleEnabled(object sender, EventArgs e)
        {
            Settings.Default.IsEnabled = !Settings.Default.IsEnabled;
            Settings.Default.Save();

            enabledMenuItem.Checked = Settings.Default.IsEnabled;
        }
        
        private void ShowSettings(object sender, EventArgs e)
        {
            using (var f = new ConfigurationForm())
            {
                f.ShowDialog();
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            mouseTrackingService.Dispose();
            trayIcon.Visible = false;
            Application.Exit();
        }
    }
}