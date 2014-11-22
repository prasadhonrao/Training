using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBoxDataBinding
{
    public class Customer
    {
        public string Name { get; set; }
        public string City { get; set; }

        public static ObservableCollection<Customer> GetCustomer()
        {
            var customers = new ObservableCollection<Customer>()
            {
                new Customer { Name ="Prasad", City="Pune"},
                new Customer { Name ="Amit", City="Mumbai"},
                new Customer { Name ="Colin", City="Glasgow"}
            };

            return customers;
        }

    }
}
