using CustomerRepository.Interface;
using System.Windows;

namespace CustomerViewer
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

        private void GetSQLDataButton_Click(object sender, RoutedEventArgs e)
        {
            GetData();
        }

        private void GetXMLDataButton_Click(object sender, RoutedEventArgs e)
        {
            GetData();
        }

        private void ClearDataButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void GetData()
        {
            ClearListBox();

            ICustomerRepository repository = CustomerRepositoryFactory.GetRepository();
            var customers = repository.GetCustomers();
            foreach (var cust in customers)
            {
                CustomerListBox.Items.Add(cust.Name);
            }
        }

        private void ClearListBox()
        {
            CustomerListBox.Items.Clear();
        }
    }
}
