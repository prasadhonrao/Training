using System;
using System.Net;
using System.Threading.Tasks;
using System.Windows;

namespace RSS_Downloader
{
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

        #region Asynchronous Operation using event
        //private void DownloadRSSButton_Click(object sender, RoutedEventArgs e)
        //{
        //    var client = new WebClient();

        //    client.DownloadStringCompleted += (s, args) =>
        //    {
        //        RSSTextBox.Text = args.Result;
        //    };

        //    client.DownloadStringAsync(new Uri(channel9RSSUrl));
        //}
        #endregion

        #region Asynchronous Operation using TPL
        private void DownloadRSSButton_Click(object sender, RoutedEventArgs e)
        {
            var client = new WebClient();
            var rss = string.Empty;

            var downloadTask = Task.Run(() =>
            {
                client.DownloadStringAsync(new Uri(channel9RSSUrl));
            });

            downloadTask.Wait();

            client.DownloadStringCompleted += (s, args) =>
            {
                Dispatcher.Invoke(() =>
                {
                    RSSTextBox.Text = args.Result;
                });
            };
        }
        #endregion

        private void IncrementCounterButton_Click(object sender, RoutedEventArgs e)
        {
            IncrementOutputLabel.Content = counter++;
        }
    }
}
