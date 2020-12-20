using Hardcodet.Wpf.TaskbarNotification;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPFTemplate
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private TaskbarIcon taskbarIcon;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            taskbarIcon = (TaskbarIcon)FindResource("TrayIcon");
        }

        protected override void OnExit(ExitEventArgs e)
        {
            taskbarIcon.Dispose();
            base.OnExit(e);
        }
    }
}
