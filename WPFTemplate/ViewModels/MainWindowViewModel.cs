using System.Windows;
using WPFTemplate.Common.ViewModels;

namespace WPFTemplate.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private Window _window;

        public string HelloWorld { get; set; } = "Hello World";

        public MainWindowViewModel(Window window)
        {
            _window = window;
        }
    }
}
