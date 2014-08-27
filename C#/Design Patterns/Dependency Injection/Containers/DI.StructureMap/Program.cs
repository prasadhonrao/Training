using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.StructureMap.Classes;
using DI.StructureMap.Interfaces;
using StructureMap;

namespace DI.StructureMap
{
    class Program
    {
        static void Main(string[] args)
        {
            Container container = new Container();
            container.Configure(reg => reg.For<IBillingProcessor>().Use<BillingProcessor>());
            container.Configure(reg => reg.For<ICustomerProcessor>().Use<CustomerProcessor>());
            container.Configure(reg => reg.For<INotifier>().Use<Notifier>());
            container.Configure(reg => reg.For<ILogger>().Use<Logger>());

            Console.WriteLine("StructureMap DI");
            Console.WriteLine();

            var orderInfo = new OrderInfo
            {
                CustomerName = "Prasad Honrao",
                Email = "Me@PrasadHonrao.com",
                Product = "iPad",
                Price = 499,
                CreditCard = 123456
            };

            var commerce = container.GetInstance<Commerce>();
            commerce.ProcessOrder(orderInfo);

            Console.WriteLine();
            Console.WriteLine("Press [Enter] to exit...");

            Console.ReadLine();
        }
    }
}
