using System;

namespace CSharp.Training
{
    class DomesticOrderProcessor : OrderProcessor
    {
        public DomesticOrderProcessor(Customer cust, Order order)
            : base(cust, order) { }

        public override void ShipOrder()
        {
            Console.WriteLine("Sent by road");
        }

        public override void UpdateToCustomer()
        {
            Console.WriteLine("Message sent to {0}", customer.Name);
        }

    }
}
