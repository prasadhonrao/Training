using CustomerRepository.ViewModel;
using System.Windows;

namespace CustomerViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CustomerViewModel viewModel;
        
        public MainWindow()
        {
            InitializeComponent();

            viewModel = new CustomerViewModel();
            this.DataContext = viewModel;
        }

        private void GetSQLDataButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.GetCustomers();
        }

        private void GetXMLDataButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.GetCustomers();
        }

        private void ClearDataButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ClearCustomers();
        }
    }
}
