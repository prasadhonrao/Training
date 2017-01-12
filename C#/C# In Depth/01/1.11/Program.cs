using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Product> products = Product.GetSampleProducts();
        Predicate<Product> test = delegate (Product p) { return p.Price > 10m; };
        List<Product> matches = products.FindAll(test);

        Action<Product> print = Console.WriteLine;
        matches.ForEach(print);
    }

    class Product
    {
        string name;
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        decimal price;
        public decimal Price
        {
            get { return price; }
            private set { price = value; }
        }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public static List<Product> GetSampleProducts()
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("West Side Story", 9.99m));
            list.Add(new Product("Assassins", 14.99m));
            list.Add(new Product("Frogs", 13.99m));
            list.Add(new Product("Sweeny Todd", 10.99m));
            return list;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }
    }
}
