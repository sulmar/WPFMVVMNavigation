using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPFMVVMNavigation.Common;
using WPFMVVMNavigation.Views;

namespace WPFMVVMNavigation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static NavigationService Navigation;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ShellView shellView = new ShellView();
            shellView.Show();

            Navigation = new NavigationService(shellView.MyFrame);
            Navigation.Navigate<FirstPageView>();
        }

    }
}
