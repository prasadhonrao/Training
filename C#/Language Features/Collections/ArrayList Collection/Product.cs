using System.Collections;
using System.Collections.Generic;

namespace Training.CSharp
{
    public class Product
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        private Product() { }

        public static ArrayList GetDefaultProducts()
        {
            var products = new ArrayList();
            
            products.Add(new Product() { Name = "CD", Price = 5.99m });
            products.Add(new Product() { Name = "Laptop", Price = 299.00m });
            products.Add(new Product() { Name = "Surface RT", Price = 399.99m});
            products.Add(new Product() { Name = "iPad", Price = 499m });
            products.Add(new Product() { Name = "Surface Pro", Price = 899.99m });

            return products;
        }

        public static List<Product> GetProducts()
        {
            var products = new List<Product>();

            products.Add(new Product() { Name = "CD", Price = 5.99m });
            products.Add(new Product() { Name = "Laptop", Price = 299.00m });
            products.Add(new Product() { Name = "Surface RT", Price = 399.99m });
            products.Add(new Product() { Name = "iPad", Price = 499m });
            products.Add(new Product() { Name = "Surface Pro", Price = 899.99m });

            return products;
        }
        
        public override string ToString()
        {
            return string.Format("{0} : {1}", this.Name, this.Price);
        }

    }
}
