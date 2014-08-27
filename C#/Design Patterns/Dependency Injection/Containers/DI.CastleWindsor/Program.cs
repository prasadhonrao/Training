using Castle.MicroKernel.Registration;
using Castle.Windsor;
using DI.CastleWindsor.Classes;
using DI.CastleWindsor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.CastleWindsor
{
    class Program
    {
        static void Main(string[] args)
        {
            IWindsorContainer container = new WindsorContainer();
            
            container.Register(Component.For<Commerce>().ImplementedBy<Commerce>());
            container.Register(Component.For<IBillingProcessor>().ImplementedBy<BillingProcessor>());
            container.Register(Component.For<ICustomerProcessor>().ImplementedBy<CustomerProcessor>());
            container.Register(Component.For<INotifier>().ImplementedBy<Notifier>());
            container.Register(Component.For<ILogger>().ImplementedBy<Logger>());

            Console.WriteLine("Castle Windsor DI");
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
