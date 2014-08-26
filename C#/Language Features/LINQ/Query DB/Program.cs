using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new NorthwindModelDataContext();
            var customers = db.Customers;
            
            foreach (var cust in customers)
            {
                Console.WriteLine(string.Format("{0} : {1}", cust.ContactName, cust.City));
            }
            Console.WriteLine();

            // Note it uses Expression and not Func delegate, so that query gets execueted on server
            Console.WriteLine("Customers living in London");
            var query = db.Customers.Where(c => c.City == "London");
            foreach (var cust in query)
            {
                Console.WriteLine(string.Format("{0} : {1}", cust.ContactName, cust.City));
            }

            Console.ReadLine();
        }
    }
}
