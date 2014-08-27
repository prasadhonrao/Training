using System.ComponentModel.Composition;
using DI.MEF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.MEF.Classes
{
    [Export(typeof(ICustomerProcessor))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class CustomerProcessor : ICustomerProcessor
    {
        public void UpdateCustomer(string customer)
        {
            Console.WriteLine("Updating to customer {0}", customer);
        }
    }
}
