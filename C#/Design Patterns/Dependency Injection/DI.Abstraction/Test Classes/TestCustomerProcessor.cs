using DI.Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Abstraction.Classes
{
    public class TestCustomerProcessor : ICustomerProcessor
    {
        public void UpdateCustomer(string customer)
        {
            Console.WriteLine("TEST : Updating to customer {0}", customer);
        }
    }
}
