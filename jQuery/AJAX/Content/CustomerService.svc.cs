using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _05Ajax.Content
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Customer" in code, svc and config file together.
    public class CustomerService : ICustomerService
    {
        public Customer GetCustomer()
        {
            Customer cust = new Customer()
            {
                ID = 1,
                FirstName = "Prasad",
                LastName = "Honrao"
            };

            return cust;
        }
    }
}
