using System;
using System.Linq;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sort products using non generic ProductComparer which involves boxing & unboxing
            Console.WriteLine("Sort products using IComparer");
            var products1 = Product.GetDefaultProducts();
            products1.Sort(new ProductComparer());
            foreach (var product in products1)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine(); 
            #endregion

            #region Sort products using generic ProductComparerGeneric which does not involve boxing & unboxing
            Console.WriteLine("Sort products using IComparer<T>");
            var products2 = Product.GetProducts();
            products2.Sort(new ProductComparerGeneric());
            foreach (var product in products1)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine(); 
            #endregion

            #region Sort Without IComparer and using delegates
            Console.WriteLine("Sort products using delegates");
            var products3 = Product.GetProducts();
            products3.Sort(delegate(Product p1, Product p2)
                                   {
                                       return p1.Name.CompareTo(p2.Name);
                                   }
                          );

            foreach (var product in products3)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine(); 
            #endregion

            #region Sort using Lambda
            Console.WriteLine("Sort products using Lambdas");
            var products4 = Product.GetProducts();
            products3.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
            foreach (var product in products4)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine(); 
            #endregion

            #region Sort using Extension Method
            Console.WriteLine("Sort products using extension method");
            var products5 = Product.GetProducts().OrderBy(p => p.Name);
            foreach (var product in products5)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine(); 
            #endregion

            #region Sort using LINQ query
            Console.WriteLine("Sort products using LINQ query");
            var products6 = from p in Product.GetProducts()
                            orderby p.Name
                            select p;
            foreach (var product in products6)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine();
            #endregion

            Console.ReadLine();
        }
    }
}
