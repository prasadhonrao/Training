using DI.Autofac.Classes;
using DI.Autofac.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Core;
using Autofac;

namespace DI.Autofac
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType(typeof(Commerce));
            builder.RegisterInstance<IBillingProcessor>(new BillingProcessor());
            builder.RegisterInstance<ICustomerProcessor>(new CustomerProcessor());
            builder.RegisterInstance<INotifier>(new Notifier());
            builder.RegisterInstance<ILogger>(new Logger());

            Console.WriteLine("Autofac DI");
            Console.WriteLine();

            var orderInfo = new OrderInfo
            {
                CustomerName = "Prasad Honrao",
                Email = "Me@PrasadHonrao.com",
                Product = "iPad",
                Price = 499,
                CreditCard = 123456
            };

            var container = builder.Build();
            var commerce = container.Resolve<Commerce>();
            commerce.ProcessOrder(orderInfo);

            Console.WriteLine();
            Console.WriteLine("Press [Enter] to exit...");

            Console.ReadLine();
        }
    }
}
