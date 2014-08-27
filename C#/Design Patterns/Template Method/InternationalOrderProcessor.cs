using System;

namespace CSharp.Training
{
    class InternationalOrderProcessor : OrderProcessor
    {
        public InternationalOrderProcessor(Customer cust, Order order)
            : base(cust, order) { }

        public override void ShipOrder()
        {
            Console.WriteLine("Sent by air");
        }

        public override void UpdateToCustomer()
        {
            Console.WriteLine("Email sent");
        }
    }
}
