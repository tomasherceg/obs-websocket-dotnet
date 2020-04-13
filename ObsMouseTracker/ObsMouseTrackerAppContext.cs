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

        public ObsMouseTrackerAppContext()
        {
            contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add(new ToolStripMenuItem("Settings", null, ShowSettings));
            contextMenu.Items.Add(new ToolStripSeparator());
            contextMenu.Items.Add(new ToolStripMenuItem("Exit", null, Exit));

            // Initialize Tray Icon
            trayIcon = new NotifyIcon()
            {
                Icon = Resources.AppIcon,
                ContextMenuStrip = contextMenu,
                Visible = true
            };

            mouseTrackingService = new MouseTrackingService();
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