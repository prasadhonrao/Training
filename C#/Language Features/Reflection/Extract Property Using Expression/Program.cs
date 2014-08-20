using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
             var c = new Customer() { Id = 1, FirstName = "Prasad", LastName = "Honrao" };
        }
    }

    public class Customer : BaseEntity
    {
        public int Id { get; set; }
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged(() => FirstName);
            }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged(() => LastName);
            }
        }
    }

    public class BaseEntity : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged<T>(Expression<Func<T>> propertyExpression)
        {
            string propertyName = PropertySupport.ExtractPropertyName(propertyExpression);
            OnPropertyChanged(propertyName);
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public static class PropertySupport
    {
        internal static string ExtractPropertyName<T>(Expression<Func<T>> propertyExpression)
        {
            string propertyName = string.Empty;

            MemberExpression e = propertyExpression.Body as MemberExpression;
            propertyName = e.Member.Name.ToString();

            return propertyName;
        }
    }
    
}
