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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AsyncAwaitWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DoComplexWork();
        }

        private async void DoComplexWork()
        {
            int maxNumber = 200000000;
            var sum = 0.0;

            for (; ; )
            {
                SumTextBlock.Text = "Computing";

                await Task.Run(() =>
                {
                    for (int i = 0; i < maxNumber; i++)
                    {
                        sum += Math.Sqrt(i);
                    }
                });

                SumTextBlock.Text = "Sum is " + sum;

                await Task.Run(() =>
                {
                    for (int i = 0; i < maxNumber; i++)
                    {
                        sum += Math.Sqrt(i);
                    }
                });

                SumTextBlock.Text = "Sum is " + sum;

                await Task.Run(() =>
                {
                    for (int i = 0; i < maxNumber; i++)
                    {
                        sum += Math.Sqrt(i);
                    }
                });

                SumTextBlock.Text = "Sum is " + sum;

                await Task.Run(() =>
                {
                    for (int i = 0; i < maxNumber; i++)
                    {
                        sum += Math.Sqrt(i);
                    }
                });

                SumTextBlock.Text = "Sum is " + sum;

            };
        }

        private void MessageButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Wow! UI was not frozen. True async app.");
        }
    }
}
