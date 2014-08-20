using CustomerRepository.Interface;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace CustomerRepository.CSV
{
    public class CSVRepository : ICustomerRepository
    {
        string filePath = string.Empty;
        public CSVRepository()
        {
            filePath = ConfigurationManager.AppSettings["Customers"];
        }

        public IEnumerable<Customer> GetCustomers()
        {
            var customers = new List<Customer>();

            var sr = new StreamReader(filePath);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                var elements = line.Split(',');
                var customer = new Customer()
                {
                    Id =  int.Parse(elements[0]),
                    Name = elements[1]
                };
                customers.Add(customer);
            }

            return customers;
        }
    }
}
