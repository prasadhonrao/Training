using System;
using System.Collections.Generic;
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
    /// Interaction logic for BasicControls.xaml
    /// </summary>
    public partial class BasicControls : Window
    {
        public BasicControls()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            var sb = new StringBuilder();
            sb.Append("Full Name :");
            sb.AppendLine(FullNameTextBox.Text);

            sb.Append("Gender :");
            if ((bool)MaleRadioButton.IsChecked)
                sb.AppendLine("Male");
            else
                sb.AppendLine("Female");

            sb.Append("You own :");
            if ((bool)DesktopCheckBox.IsChecked)
                sb.AppendLine("Desktop ");
            if ((bool)LaptopCheckBox.IsChecked)
                sb.Append("Laptop ");
            if ((bool)TabletCheckBox.IsChecked)
                sb.Append("Tablet ");

            sb.Append("Your job :");
            sb.AppendLine(JobsComboBox.SelectedValue.ToString());

            sb.Append("Birthdate:");
            sb.AppendLine(BirthDateCalendar.SelectedDate.ToString());

            MessageBox.Show(sb.ToString());
        }
    }
}
