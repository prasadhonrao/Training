using System;
using System.Collections.Generic;

namespace Training.CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Predicate<double> isEvenNumber = d => d % 2 == 0;
            Console.WriteLine("10 is even number? - " + isEvenNumber(10));
            Console.WriteLine("11 is even number? - " + isEvenNumber(11));
            Console.WriteLine();

            Console.WriteLine("Product example");

            var products = Product.GetSampleProducts();
            Predicate<Product> iProducts = delegate(Product p) { return p.Name.StartsWith("i"); };
            var matches = products.FindAll(iProducts);
            Action<Product> print = Console.WriteLine;
            matches.ForEach(print);

            Console.ReadLine();
        }
    }
}
