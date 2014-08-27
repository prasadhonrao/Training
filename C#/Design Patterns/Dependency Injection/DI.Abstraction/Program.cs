using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Abstraction.Classes;

namespace DI.Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderInfo = new OrderInfo
            {
                CustomerName = "Prasad Honrao",
                Email = "Me@PrasadHonrao.com",
                Product = "iPad",
                Price = 499,
                CreditCard = 123456
            };

            // Production
            var commerce = new Commerce(new BillingProcessor(),
                                        new CustomerProcessor(),
                                        new Notifier(),
                                        new Logger());

            commerce.ProcessOrder(orderInfo);
            Console.WriteLine("Order processed successfully");

            Console.WriteLine("-----------------------------");

            // Test
            var testCommerce = new Commerce(new TestBillingProcessor(),
                                        new TestCustomerProcessor(),
                                        new TestNotifier(),
                                        new TestLogger());

            testCommerce.ProcessOrder(orderInfo);
            Console.WriteLine("Test Order processed successfully");

            Console.ReadLine();
        }
    }
}
