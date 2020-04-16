﻿using System.Windows;
using WPFTemplate.ViewModels;

namespace WPFTemplate.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowViewModel(this);
        }
    }
}
