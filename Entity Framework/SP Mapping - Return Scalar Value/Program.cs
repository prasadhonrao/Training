using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Mapping___Return_Scalar_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AWEntities())
            {
                ObjectResult<int?> count = context.GetProductCategoryCount();
                Console.WriteLine("Product category count {0}", count.First().Value);
            }

            Console.WriteLine("Press [Enter] to exit...");
            Console.ReadLine();
        }
    }
}
