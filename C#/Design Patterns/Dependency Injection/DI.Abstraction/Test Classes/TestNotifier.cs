using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DI.Abstraction.Classes;
using DI.Abstraction.Interfaces;

namespace DI.Abstraction
{
    public class TestNotifier : INotifier
    {
        public void SendReceipt(OrderInfo orderInfo)
        {
            Console.WriteLine("TEST : Sending receipt to customer {0} for {1} with amount {2}",
                               orderInfo.CustomerName, orderInfo.Product, orderInfo.Price);
        }
    }
}
