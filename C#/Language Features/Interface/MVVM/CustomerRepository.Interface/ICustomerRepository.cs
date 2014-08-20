using System.Collections.Generic;

namespace CustomerRepository.Interface
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
    }
}
