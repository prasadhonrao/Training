using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DI.StructureMap.Classes;
using DI.StructureMap.Interfaces;

namespace DI.StructureMap
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
