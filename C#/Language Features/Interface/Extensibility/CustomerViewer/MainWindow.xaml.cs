using CustomerRepository.Interface;
using System.Windows;

namespace CustomerViewer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetSQLDataButton_Click(object sender, RoutedEventArgs e)
        {
            GetData("SQL");
        }

        private void GetXMLDataButton_Click(object sender, RoutedEventArgs e)
        {
            GetData("XML");
        }

        private void GetCSVDataButton_Click(object sender, RoutedEventArgs e)
        {
            GetData("CSV");
        }

        private void ClearDataButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void GetData(string repositoryType)
        {
            ClearListBox();

            ICustomerRepository repository = CustomerRepositoryFactory.GetRepository(repositoryType);
            var customers = repository.GetCustomers();
            CustomerListBox.ItemsSource = customers;
            DisplayRepositoryType(repository);
        }

        private void DisplayRepositoryType(ICustomerRepository repo)
        {
            RepoTypeTextBlock.Text = "Repository Type : " + repo.GetType().FullName;
        }

        private void ClearListBox()
        {
            CustomerListBox.ItemsSource = null;
            RepoTypeTextBlock.Text = string.Empty;
        }
    }
}
