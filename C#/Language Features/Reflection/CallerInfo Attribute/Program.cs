using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee();
            employee.PropertyChanged += (s, e) => Console.WriteLine("{0} property value changed", e.PropertyName);

            employee.FirstName = "Prasad Honrao";

            Console.WriteLine(employee.FirstName);
            Console.Read();
        }
    }

    public class Employee : INotifyPropertyChanged
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value != firstName)
                {
                    firstName = value;
                    OnPropertyChanged();
                }
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
