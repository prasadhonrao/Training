using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Database_First___Data_Load_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            EagerLoad();
            ExplicitLoad();
        }

        private static void ExplicitLoad()
        {
            using (var context = new AWEntities())
            {
                var customer = context.Customers.First();
                context.Entry(customer).Collection(c => c.SalesOrderHeaders).Load();

                Console.WriteLine("{0} : {1}", customer.AccountNumber, customer.SalesOrderHeaders.Count());
            }
        }

        private static void EagerLoad()
        {
            using (var context = new AWEntities())
            {
                // Include lambda extension method needs System.Data.Entity using statement
                var customersWithOrders = context.Customers.Include(c => c.SalesOrderHeaders).ToList();

                foreach (var customer in customersWithOrders)
                {
                    Console.WriteLine("{0} : {1}", customer.AccountNumber, customer.SalesOrderHeaders.Count());
                }
            }
        }
    }
}
