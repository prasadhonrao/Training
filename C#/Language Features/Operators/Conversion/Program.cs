using System;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = 100;
            Console.WriteLine("Product Price {0}", p.Price);

            Product p1 = (Product) "CD";
            Console.WriteLine("Product name {0}", p1.Name);

            Console.ReadLine();

        }
    }
}
