using System;
using System.Collections.Generic;

public class Program
{
    class Product
    {
        readonly string name;
        public string Name
        {
            get
            {
                return name;
            }
        }

        readonly decimal price;
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
            return new List<Product>()
            {
                list.Add(new Product(name: "West Side Story", price: 9.99m)),
                list.Add(new Product(name: "Assassins", price: 14.99m)),
                list.Add(new Product(name: "Frogs", price: 13.99m)),
                list.Add(new Product(name: "Sweeny Todd", price: 10.99m))
            };
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }
    }
}
