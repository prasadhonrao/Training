using System;
using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        ArrayList products = Product.GetSampleProducts();
        foreach (Product product in products)
        {
            if (product.Price > 10m)
            {
                Console.WriteLine(product);
            }
        }
    }

    class Product
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
        }

        decimal price;
        public decimal Price
        {
            get
            {
                return price;
            }
        }

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public static ArrayList GetSampleProducts()
        {
            ArrayList list = new ArrayList();
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
