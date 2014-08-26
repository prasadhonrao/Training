using System.Collections.Generic;

namespace Training.CSharp
{
    class CustomerRepository
    {
        public static List<Customer> GetSampleCustomers()
        {
            var customers = new List<Customer>();

            customers.Add(new Customer() { Name = "Prasad", City = "London" });
            customers.Add(new Customer() { Name = "Colin", City = "Glasgow" });
            customers.Add(new Customer() { Name = "Scott", City = "New York" });
            customers.Add(new Customer() { Name = "John", City = "Florida" });
            customers.Add(new Customer() { Name = "Dan", City = "London" });

            return customers;
        }
    }
}
