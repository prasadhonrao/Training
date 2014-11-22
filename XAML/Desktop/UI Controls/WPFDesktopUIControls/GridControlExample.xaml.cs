using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFDesktopUIControls
{
    /// <summary>
    /// Interaction logic for GridControlExample.xaml
    /// </summary>
    public partial class GridControlExample : Window
    {
        public GridControlExample()
        {
            InitializeComponent();

            EmployeeGrid.ItemsSource = Employee.GetEmployees();
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public bool IsManager { get; set; }
        public DesignationType Designation { get; set; }

        public static ObservableCollection<Employee> GetEmployees()
        {
            var employees = new ObservableCollection<Employee>()
            {
                new Employee { Name="Prasad Honrao" , IsManager = false, Designation = DesignationType.Architect },
                new Employee { Name="Colin Gray" , IsManager = true, Designation = DesignationType.ProjectMananger },
            };

            return employees;
        }
    }

    public enum DesignationType
    {
        Associate,
        Architect,
        ProjectMananger,
        Director,
        CBT,
        CEO
    }
}
