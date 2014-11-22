using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPFDesktopUIControls
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            //this.StartupUri = new Uri("BasicControls.xaml", UriKind.RelativeOrAbsolute);
            //this.StartupUri = new Uri("MenuExample.xaml", UriKind.RelativeOrAbsolute);
            //this.StartupUri = new Uri("TabPanelExample.xaml", UriKind.RelativeOrAbsolute);
            //this.StartupUri = new Uri("GridControlExample.xaml", UriKind.RelativeOrAbsolute);
            this.StartupUri = new Uri("TreeViewExample.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}
