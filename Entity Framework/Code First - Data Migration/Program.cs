using Code_First___Data_Migration.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First___Data_Migration
{
    class Program
    {
        static void Main(string[] args)
        {
            SetupMigration();

            using (var context = new SalesContext())
            {
                var customers = context.Customers.ToList();
                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.FirstName);
                }
            }
            Console.ReadLine();
        }

        private static void SetupMigration()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SalesContext, Configuration>());
        }
    }


    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
//        public DateTime BirthDate { get; set; }
    }

    public class SalesContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
