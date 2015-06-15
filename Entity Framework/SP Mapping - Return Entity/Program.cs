using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Mapping___Return_Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AWEntities())
            {
                var details = context.GetProductCategory(1).FirstOrDefault();
                Console.WriteLine(details.Name);
            }

            Console.WriteLine("Press [Enter] to exit...");
            Console.ReadLine();
        }
    }
}
