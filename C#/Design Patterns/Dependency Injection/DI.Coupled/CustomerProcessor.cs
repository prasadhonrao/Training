using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DI.Coupled
{
    public class CustomerProcessor
    {
        internal void UpdateCustomer(string customer)
        {
            Console.WriteLine("Updating to customer {0}", customer);
        }
    }
}
