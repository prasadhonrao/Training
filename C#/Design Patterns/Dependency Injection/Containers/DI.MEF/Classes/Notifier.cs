using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using DI.MEF.Classes;
using DI.MEF.Interfaces;

namespace DI.MEF.Classes
{
    [Export(typeof(INotifier))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class Notifier : INotifier
    {
        public void SendReceipt(OrderInfo orderInfo)
        {
            Console.WriteLine("Sending receipt to customer {0} for {1} with amount {2}",
                               orderInfo.CustomerName, orderInfo.Product, orderInfo.Price);
        }
    }
}
