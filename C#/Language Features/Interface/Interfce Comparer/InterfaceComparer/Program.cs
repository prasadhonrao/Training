using System;
using System.Collections.Generic;
using System.Linq;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sort Using Non Generic IComparer
            Console.WriteLine("Sort Products by name using Non Generic ProductNameComparer ");
            var products = Product.GetSampleProductsInArrayList();
            products.Sort(new ProductNameComparer());

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();

            Console.WriteLine("Sort Products by name using Non Generic ProductPriceComparer");
            products.Sort(new ProductPriceComparer());

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine(); 
            #endregion

            #region Sort Using Generic Comparer
            Console.WriteLine("Sort Products by name using Generic ProductNameComparer ");
            List<Product> list = Product.GetSampleProductsInList();
            list.Sort(new ProductNameGenericComparer());
            foreach (var product in list)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine(); 
            #endregion

            #region Sort Using Anonymous Method
            Console.WriteLine("Sort using anonymous method");
            List<Product> listAna = Product.GetSampleProductsInList();
            listAna.Sort(delegate(Product first, Product second)
            {
                return first.Name.CompareTo(second.Name);
            });
            foreach (var product in listAna)
            {
                Console.WriteLine(product);
            } 
            Console.WriteLine();
            #endregion

            #region Sort Using Lambda Expression
            Console.WriteLine("Sort using lambda");
            var listLambda = Product.GetSampleProductsInList();
            listLambda.Sort((first, second) => first.Name.CompareTo(second.Name));
            foreach (var product in listLambda)
            {
                Console.WriteLine(product);
            } 
            #endregion

            Console.ReadLine();
        }
    }
}
