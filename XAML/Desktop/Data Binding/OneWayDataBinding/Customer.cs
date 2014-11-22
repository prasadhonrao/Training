using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWayDataBinding
{
    public class Customer
    {
        public string Name { get; set; }
        public string City { get; set; }

        public static Customer GetCustomer()
        {
            var cust = new Customer() { Name = "Prasad", City = "London" };
            return cust;
        }
    }
}
