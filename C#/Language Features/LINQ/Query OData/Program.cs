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
            var categories = db.Categories;

            Console.WriteLine("Categories");
            foreach (var category in categories)
            {
                Console.WriteLine(category.CategoryName);
            }

            Console.WriteLine();
            #endregion

            #region 2. Get Customers in London
            Console.WriteLine("Customers in London");
            var CustomersInLondon = db.Customers.Where(c => c.City == "London");
            foreach (var customer in CustomersInLondon)
            {
                Console.WriteLine(customer.ContactName);
            }
            Console.WriteLine();
            #endregion

            #region 3. Call View / SP

            Console.WriteLine("Alphabetical list of products");
            var products = db.Alphabetical_list_of_products.OrderBy(p => p.ProductName); // Alphabetical_list_of_products service does not return in products in alphabetical order!
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine();

            #endregion

            Console.ReadLine();

        }
    }
}
