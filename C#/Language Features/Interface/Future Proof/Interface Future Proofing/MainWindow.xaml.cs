using System.Collections;
using System.Windows;

namespace Training.CSharp
{
    public partial class MainWindow : Window
    {
        EmployeeRepository repo = new EmployeeRepository();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClearDataButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ConcreteClassButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();

            Employee[] employees = repo.GetUsingConcreteClass();
            // List<Employee> employees = repo.GetUsingConcreteClass();
            EmployeeList.ItemsSource = employees;
        }

        private void InterfaceButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();

            IEnumerable employees = repo.GetUsingInterface();
            EmployeeList.ItemsSource = employees;
        }

        private void ClearListBox()
        {
            EmployeeList.ItemsSource = null;
        }
    }
}
