using CustomerRepository.Interface;
using System.Collections.Generic;

namespace CustomerRepository.Fake
{
    public class FakeRepository : ICustomerRepository
    {
        IEnumerable<Customer> ICustomerRepository.GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer { Id = 1, Name = "Fake 1" });
            customers.Add(new Customer { Id = 2, Name = "Fake 2" });

            return customers;
        }
    }
}
