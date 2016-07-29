using System;
using System.Linq;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new NorthwindEntities();

            var customers = db.Customers;
            foreach (var cust in customers)
            {
                Console.WriteLine(string.Format("{0} : {1}", cust.ContactName, cust.City));
            }
            Console.WriteLine();

            // Note it uses Expression and not Func delegate, so that query gets executed on server
            Console.WriteLine("Customers living in London");
            var query = db.Customers.Where(c => c.City == "London");
            foreach (var cust in query)
            {
                Console.WriteLine(string.Format("{0} : {1}", cust.ContactName, cust.City));
            }

            // Count is greedy
            var londonCustomerCount = (from c in db.Customers
                                      where c.City == "London"
                                      select c).Count();
            Console.WriteLine("Number of customers living in London : " + londonCustomerCount);
            Console.ReadLine();
        }
    }
}
