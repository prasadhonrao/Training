using System.Windows;

namespace Introduction
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

        private void ClickMeButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I am clicked!", "Introduction", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
