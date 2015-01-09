using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.ViewModels
{
    class CustomerPageViewModel : INotifyPropertyChanged
    {
        private Customer _customer;

        public Customer Customer
        {
            get { return _customer; }
            set
            {
                if (_customer != value)
                {
                    _customer = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Customer"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
