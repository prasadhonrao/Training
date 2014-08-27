using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DI.Coupled
{
    public class BillingProcessor
    {
        internal void ProcessPayment(string customerName, int creditCard, int price)
        {
            Console.WriteLine("Processing payment of {0} for customer {1} with credit card {2}", price, customerName, creditCard);
        }
    }
}
