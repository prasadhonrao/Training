using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Coupled
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

            var commerce = new Commerce(new BillingProcessor(),
                                        new CustomerProcessor(),
                                        new Notifier(),
                                        new Logger());

            commerce.ProcessOrder(orderInfo);

            Console.WriteLine("Order processed successfully");

            Console.ReadLine();
        }
    }
}
