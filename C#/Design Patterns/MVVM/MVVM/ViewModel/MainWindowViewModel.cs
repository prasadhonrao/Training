using MVVM.Command;
using MVVM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private Person _person;
        private SavePersonCommand _savePerson;

        public SavePersonCommand SavePerson
        {
            get { return _savePerson; }
            set
            {
                _savePerson = value;
                OnPropertyChanged();
            }
        }


        public Person Person
        {
            get { return _person; }
            set
            {
                _person = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            this.Person = new Person()
            {
                FirstName = "Prasad",
                LastName = "Honrao",
                LastUpdated = DateTime.Now
            };

            this.SavePerson = new SavePersonCommand(SavePersonHandler);
        }

        private void SavePersonHandler()
        {
            Person.LastUpdated = DateTime.Now;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
