using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DI.Unity.Classes;
using DI.Unity.Interfaces;

namespace DI.Unity
{
    public class Notifier : INotifier
    {
        public void SendReceipt(OrderInfo orderInfo)
        {
            Console.WriteLine("Sending receipt to customer {0} for {1} with amount {2}",
                               orderInfo.CustomerName, orderInfo.Product, orderInfo.Price);
        }
    }
}
