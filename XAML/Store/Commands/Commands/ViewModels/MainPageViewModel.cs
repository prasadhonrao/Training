using Commands.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace Commands.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public RelayCommand<string> NavigateCommand { get; set; }


        public MainPageViewModel()
        {
            NavigateCommand = new RelayCommand<string>(OnExecute, OnCanExecute);
        }

        private bool OnCanExecute(string input)
        {
            if (input.Trim().Length == 0)
                return false;
            return true;
        }

        private async void OnExecute(string input)
        {
            var messageDialog = new MessageDialog(input);
            await messageDialog.ShowAsync();
        }

        private string _title = "";

        public string Title
        {
            get { return _title; }
            set
            {
                if (value != _title)
                {
                    _title = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Title"));
                    NavigateCommand.RaiseCanExecuteChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        //private void OnTitleChanged(object sender, PropertyChangedEventArgs e)
        //{
        //    NavigateCommand.RaiseCanExecuteChanged();
        //}
    }
}
