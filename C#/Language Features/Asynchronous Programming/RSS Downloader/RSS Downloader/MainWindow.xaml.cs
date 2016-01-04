using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RSS_Downloader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int counter = 0;
        string channel9RSSUrl = "https://channel9.msdn.com/Feeds/RSS";

        public MainWindow()
        {
            InitializeComponent();
        }

        #region Synchronous Operation
        //private void DownloadRSSButton_Click(object sender, RoutedEventArgs e)
        //{
            
        //    var client = new WebClient();
        //    var rss = client.DownloadString(channel9RSSUrl);
        //    RSSTextBox.Text = rss;
        //}
        #endregion

        #region Asynchronous Operation
        private void DownloadRSSButton_Click(object sender, RoutedEventArgs e)
        {
            var client = new WebClient();

            client.DownloadStringCompleted += (s, args) =>
            {
                RSSTextBox.Text = args.Result;
            };

            client.DownloadStringAsync(new Uri(channel9RSSUrl));
        }
        #endregion

        private void IncrementCounterButton_Click(object sender, RoutedEventArgs e)
        {
            IncrementOutputLabel.Content = counter++;
        }
    }
}
