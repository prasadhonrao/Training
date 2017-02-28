using System;
using System.Linq;
using Training.CSharp.NorthwindServiceReference;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new NorthwindEntities(new Uri("http://services.odata.org/Northwind/Northwind.svc"));

            #region 1. Display Categories

            Console.WriteLine("Categories");
            
            //var categories = db.Categories;
            //foreach (var category in categories)
            //{
            //    Console.WriteLine(category.CategoryName);
            //}

            db.Categories.ToList().ForEach(c => Console.WriteLine(c.CategoryName));

            Console.WriteLine();
            #endregion

            #region 2. Get Customers in London

            Console.WriteLine("Customers in London");
            //var CustomersInLondon = db.Customers.Where(c => c.City == "London");
            //foreach (var customer in CustomersInLondon)
            //{
            //    Console.WriteLine(customer.ContactName);
            //}

            db.Customers.Where(c => c.City == "London").ToList().ForEach(c => Console.WriteLine(c.ContactName));
            Console.WriteLine();


            #endregion

            #region 3. Call View / SP

            Console.WriteLine("Alphabetical list of products");

            // Alphabetical_list_of_products service does not return in products in alphabetical order!
            //var products = db.Alphabetical_list_of_products.OrderBy(p => p.ProductName); 
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            db.Alphabetical_list_of_products.OrderBy(p => p.ProductName).ToList().ForEach(p => Console.WriteLine(p.ProductName));

            Console.WriteLine();

            #endregion

            Console.ReadLine();

        }
    }
}
