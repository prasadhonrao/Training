using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.NInject.Classes;
using DI.NInject.Interfaces;
using Ninject;

namespace DI.NInject
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel container = new StandardKernel();
            container.Bind<IBillingProcessor>().To<BillingProcessor>();
            container.Bind<ICustomerProcessor>().To<CustomerProcessor>();
            container.Bind<INotifier>().To<Notifier>();
            container.Bind<ILogger>().To<Logger>();

            Console.WriteLine("NInject DI");
            Console.WriteLine();

            var orderInfo = new OrderInfo
            {
                CustomerName = "Prasad Honrao",
                Email = "Me@PrasadHonrao.com",
                Product = "iPad",
                Price = 499,
                CreditCard = 123456
            };

            var commerce = container.Get<Commerce>();
            commerce.ProcessOrder(orderInfo);

            Console.WriteLine();
            Console.WriteLine("Press [Enter] to exit...");

            Console.ReadLine();
        }
    }
}
