using System.Windows;
using WPFTemplate.Common.ViewModels;

namespace WPFTemplate.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private Window _window;

        public string HelloWorld { get; set; } = "Hello World";

        public MainViewModel(Window window)
        {
            _window = window;
        }
    }
}
