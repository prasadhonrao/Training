using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DI.Coupled
{
    public class Notifier
    {
        internal void SendReceipt(OrderInfo orderInfo)
        {
            Console.WriteLine("Sending receipt to customer {0} for {1} with amount {2}",
                               orderInfo.CustomerName, orderInfo.Product, orderInfo.Price);
        }
    }
}
