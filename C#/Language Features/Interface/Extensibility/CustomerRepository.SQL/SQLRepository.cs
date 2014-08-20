using CustomerRepository.Interface;
using System.Collections.Generic;

namespace CustomerRepository.SQL
{
    public class SQLRepository : ICustomerRepository
    {
        IEnumerable<Customer> ICustomerRepository.GetCustomers()
        {
            // Get Data From SQL. For test purpose we are returning in memory data

            var customers = new List<Customer> 
            { 
                new Customer { Id = 1, Name = "Prasad" },
                new Customer { Id = 2, Name = "Amit" },
                new Customer { Id = 3, Name = "Colin" },
                new Customer { Id = 4, Name = "John" },
                new Customer { Id = 5, Name = "Scott" },
            };

            return customers;
        }
    }
}
