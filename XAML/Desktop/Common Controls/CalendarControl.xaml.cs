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

namespace Common_Controls
{
    /// <summary>
    /// Interaction logic for CalendarControl.xaml
    /// </summary>
    public partial class CalendarControl : Window
    {
        public CalendarControl()
        {
            InitializeComponent();
        }

        private void birthdayCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            OutputTextBlock.Text = birthdayCalendar.SelectedDate.Value.ToShortDateString();
        }
    }
}
