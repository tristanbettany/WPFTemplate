using System;
using System.Windows;
using WPFTemplate.Common.Commands;
using WPFTemplate.Common.ViewModels;

namespace WPFTemplate.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private Window _window;

        public RelayCommand HelloWorldCommand { get; set; }

        public MainViewModel(Window window)
        {
            _window = window;

            HelloWorldCommand = new RelayCommand(HelloWorld);
        }

        private void HelloWorld(object obj)
        {
            MessageBox.Show("Hello World");
        }
    }
}
