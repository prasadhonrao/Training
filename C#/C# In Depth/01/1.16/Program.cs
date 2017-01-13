using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Product> products = Product.GetSampleProducts();
        List<Supplier> suppliers = Supplier.GetSampleSuppliers();

        var filtered = from Product p in products
                       join s in suppliers
                       on p.SupplierId equals s.SupplierId
                       where p.Price > 10
                       orderby s.Name, p.Name
                       select new
                       {
                           SupplierName = s.Name,
                           ProductName = p.Name
                       };

        foreach (var v in filtered)
        {
            Console.WriteLine("Supplier={0}; Product={1}", v.SupplierName, v.ProductName);
        }
    }

    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string SupplierId { get; set; }

        public Product(string name, decimal price, string supplierId)
        {
            Name = name;
            Price = price;
            SupplierId = supplierId;
        }

        public static List<Product> GetSampleProducts()
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("West Side Story", 9.99m, "1"));
            list.Add(new Product("Assassins", 14.99m, "2"));
            list.Add(new Product("Frogs", 13.99m, "1"));
            list.Add(new Product("Sweeny Todd", 10.99m, "3"));
            return list;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Name, Price);
        }
    }

    class Supplier
    {
        public string SupplierId { get; set; }
        public string Name { get; set; }

        public Supplier(string supplierId, string name)
        {
            this.SupplierId = supplierId;
            this.Name = name;
        }

        public static List<Supplier> GetSampleSuppliers()
        {
            return new List<Supplier>()
            {
                new Supplier("1","Solely Sondheim"),
                new Supplier("2","CD-by-CD-by-Sondheim"),
                new Supplier("3","Barbershop CDs")
            };
        }
    }
}
