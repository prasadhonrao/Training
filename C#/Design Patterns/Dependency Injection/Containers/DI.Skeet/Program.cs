using DI.Skeet.Classes;
using DI.Skeet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Skeet
{
    class Program
    {
        static void Main(string[] args)
        {
            Container container = new Container();
            container.Register<IBillingProcessor, BillingProcessor>();
            container.Register<ICustomerProcessor, CustomerProcessor>();
            container.Register<INotifier, Notifier>();
            container.Register<ILogger, Logger>();

            Console.WriteLine("Skeet DI");
            Console.WriteLine();

            var orderInfo = new OrderInfo
            {
                CustomerName = "Prasad Honrao",
                Email = "Skeet@PrasadHonrao.com",
                Product = "iPad",
                Price = 499,
                CreditCard = 123456
            };

            var commerce = container.Resolve<Commerce>();
            commerce.ProcessOrder(orderInfo);

            Console.WriteLine();
            Console.WriteLine("Press [Enter] to exit...");

            Console.ReadLine();
        }
    }
}
