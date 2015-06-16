using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance___Table_Per_Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AWEntities())
            {
                Console.WriteLine("List of Active Vendors \n");
                var activeVendor = context.Vendors.OfType<ActiveVendor>();
                foreach (var vendor in activeVendor)
                {
                    Console.WriteLine(vendor.Name);
                }
            }

            Console.WriteLine("Press [Enter] to exit...");
            Console.ReadLine();
        }
    }
}
