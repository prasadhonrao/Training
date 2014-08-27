using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.CastleWindsor.Interfaces;

namespace DI.CastleWindsor.Classes
{
    public class BillingProcessor : IBillingProcessor
    {
        public void ProcessPayment(string customerName, int creditCard, int price)
        {
            Console.WriteLine("Processing payment of {0} for customer {1} with credit card {2}", price, customerName, creditCard);
        }
    }
}
