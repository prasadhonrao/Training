using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_First___Complex_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AWEntities())
            {
                var products = context.Products
                                      .Where(p => p.ProductAttributes.Color == "Blue")
                                      .Select(p => p.Name);

                foreach (var item in products)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadLine();
        }
    }
}
