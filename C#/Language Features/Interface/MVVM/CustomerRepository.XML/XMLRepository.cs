using CustomerRepository.Interface;
using System.Collections.Generic;
using System.Xml.Linq;

namespace CustomerRepository.XML
{
    public class XMLRepository : ICustomerRepository
    {
        IEnumerable<Customer> ICustomerRepository.GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            XDocument doc = XDocument.Load("customers.xml");

            foreach (var item in doc.Descendants("Customer"))
            {
                customers.Add(new Customer() { Name = item.Element("ContactName").Value });
            }

            return customers;
        }
    }
}
