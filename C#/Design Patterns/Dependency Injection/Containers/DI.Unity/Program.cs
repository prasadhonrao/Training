using DI.Unity.Classes;
using DI.Unity.Interfaces;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Unity
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();
            container.RegisterType<IBillingProcessor, BillingProcessor>();
            container.RegisterType<ICustomerProcessor, CustomerProcessor>();
            container.RegisterType<INotifier, Notifier>();
            container.RegisterType<ILogger, Logger>();

            Console.WriteLine("Unity DI");
            Console.WriteLine();

            var orderInfo = new OrderInfo
            {
                CustomerName = "Prasad Honrao",
                Email = "Me@PrasadHonrao.com",
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
