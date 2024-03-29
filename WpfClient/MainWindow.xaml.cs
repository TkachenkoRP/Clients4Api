﻿using System.Windows;
using WpfClient.ViewModel;

namespace WpfClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();

            Application.Current.MainWindow = this;

            btnUser.Visibility = Visibility.Collapsed;
            btnRole.Visibility = Visibility.Collapsed;
        }
    }
}
