using System;
using System.Windows;

namespace StockHoldingsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.GetStockButton.Click += GetStockButton_Click;
        }

        async void GetStockButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                GetStockButton.IsEnabled = false;
                var userName = UsernameTextBox.Text;
                var password = PasswordTextBox.Text;

                OutputText.Text = string.Empty;
                WriteToOutputTextBox("Authenticating user {0}", userName);

                var isUserAuthenticated = await UserAuthenticationService.AuthenticateAsync(userName, password);

                if (isUserAuthenticated)
                {
                    WriteToOutputTextBox("User {0} authenticated", userName);
                }
                else
                {
                    WriteToOutputTextBox("User {0} authentication failed", userName);
                    return;
                }

                var stocks = await StockHoldingService.GetStockAsync(userName);

                if (stocks != null)
                {
                    WriteToOutputTextBox("User {0} has {1} {2} stocks", userName, stocks.Item2, stocks.Item1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GetStockButton.IsEnabled = true;
            }
        }

        private void WriteToOutputTextBox(string message, params object[] p)
        {
            OutputText.Text += string.Format(message +  "\r\n", p);
        }
    }
}
