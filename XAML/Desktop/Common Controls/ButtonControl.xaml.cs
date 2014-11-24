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
    /// Interaction logic for ButtonControl.xaml
    /// </summary>
    public partial class ButtonControl : Window
    {
        public ButtonControl()
        {
            InitializeComponent();
            BindButtonEventHandler();
        }

        private void BindButtonEventHandler()
        {
            this.Button1.Click += Button_Click;
            this.Button2.Click += Button_Click;
            this.Button3.Click += Button_Click;
            this.Button4.Click += Button_Click;
        }

        void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button) sender;
            string message = string.Format("Button {0} was clicked", button.Content);
            MessageBox.Show(message);
        }
    }
}
