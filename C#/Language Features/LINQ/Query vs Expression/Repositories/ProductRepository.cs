using System.Collections.Generic;

namespace Training.CSharp
{
    public class ProductRepository
    {
        public static List<Product> GetSampleProducts()
        {
            return new List<Product>
            {
                new Product { ID = 1, Name = "CD", Price=5.5m},
                new Product { ID = 2, Name = "Laptop", Price = 299.00m },
                new Product { ID = 3, Name = "Surface RT", Price = 399.99m },
                new Product { ID = 4, Name = "iPad", Price = 499m },
                new Product { ID = 5, Name = "Surface Pro", Price = 899.99m }
            };
        }

        public static List<Product> GetSampleProductsWithSupplier()
        {
            return new List<Product>
            {
                new Product { Name = "Surface RT", Price = 399.99m, SupplierId = 1 },
                new Product { Name = "Surface Pro", Price = 899.99m , SupplierId = 1 },
                new Product { Name = "iPad", Price = 499m, SupplierId = 2 },
                new Product { Name = "iPad Mini", Price = 399m, SupplierId = 2 },
                new Product { Name = "iPhone", Price = 399m, SupplierId = 2 },
                new Product { Name = "Galaxy", Price = 399m, SupplierId = 3 },
                new Product { Name = "Galaxy Tablet", Price = 399m, SupplierId = 3 },
                new Product { Name = "Nexus", Price = 399m, SupplierId = 4 },
                new Product { Name = "Printer", Price = 99.99m, SupplierId = 5 },
                new Product { Name = "CD", Price=5.5m, SupplierId = 5},
                new Product { Name = "Laptop", Price = 299.00m, SupplierId = 5 },
            };
        }
    }
}
