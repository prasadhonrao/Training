using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using DI.MEF.Classes;

namespace DI.MEF
{
    class Program
    {
        public static CompositionContainer Container;
        static void Main(string[] args)
        {
            AggregateCatalog catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));
            Container = new CompositionContainer(catalog);

            Console.WriteLine("MEF DI");
            Console.WriteLine();

            var orderInfo = new OrderInfo
            {
                CustomerName = "Prasad Honrao",
                Email = "Me@PrasadHonrao.com",
                Product = "iPad",
                Price = 499,
                CreditCard = 123456
            };

            var commerce = Container.GetExportedValue<Commerce>();
            commerce.ProcessOrder(orderInfo);

            Console.WriteLine();
            Console.WriteLine("Press [Enter] to exit...");

            Console.ReadLine();
        }
    }
}
