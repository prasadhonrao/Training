using CustomerRepository.Interface;
using System.Collections.Generic;

namespace CustomerRepository.SQL
{
    public class SQLRepository : ICustomerRepository
    {
        IEnumerable<Customer> ICustomerRepository.GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer { Id = 1, Name = "Prasad" });
            customers.Add(new Customer { Id = 2, Name = "Amit" });
            customers.Add(new Customer { Id = 3, Name = "Colin" });
            customers.Add(new Customer { Id = 4, Name = "Scott" });

            return customers;
        }
    }
}
