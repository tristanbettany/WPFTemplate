using System;
using System.Windows;
using WPFTemplate.Common.Commands;
using WPFTemplate.Common.ViewModels;
using WPFTemplate.Views;

namespace WPFTemplate.ViewModels
{
    public class TrayIconViewModel : BaseViewModel
    {
        public RelayCommand ShowMainWindowCommand { get; set; }
        public RelayCommand HideMainWindowCommand { get; set; }
        public RelayCommand ExitApplicationCommand { get; set; }
        public RelayCommand ToggleMainWindowCommand { get; set; }

        public TrayIconViewModel()
        {
            ShowMainWindowCommand = new RelayCommand(ShowMainWindow, CanShowMainWindow);
            HideMainWindowCommand = new RelayCommand(HideMainWindow, CanHideMainWindow);
            ToggleMainWindowCommand = new RelayCommand(ToggleMainWindow);
            ExitApplicationCommand = new RelayCommand(ExitApplication);
        }

        private bool CanShowMainWindow(object obj)
        {
            return Application.Current.MainWindow == null;
        }

        private void ShowMainWindow(object obj)
        {
            Application.Current.MainWindow = new MainWindow();
            Application.Current.MainWindow.Show();
        }

        private bool CanHideMainWindow(object obj)
        {
            return Application.Current.MainWindow != null;
        }

        private void HideMainWindow(object obj)
        {
            Application.Current.MainWindow.Close();
        }

        private void ToggleMainWindow(object obj)
        {
            if (CanShowMainWindow(obj) == true)
            {
                ShowMainWindow(obj);
            } 
            else
            {
                HideMainWindow(obj);
            }
        }

        private void ExitApplication(object obj)
        {
            Application.Current.Shutdown();
        }
    }
}
