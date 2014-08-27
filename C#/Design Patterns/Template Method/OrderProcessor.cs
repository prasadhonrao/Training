using System;
namespace CSharp.Training
{
    public abstract class OrderProcessor
    {
        public Customer customer { get; set; }
        public Order order { get; set; }

        public OrderProcessor(Customer cust, Order order)
        {
            this.customer = cust;
            this.order = order;
        }

        // Template Method
        public void Process()
        {
            VerifyCustomerDetails();
            VerifyOrderDetails();
            ShipOrder();
            UpdateToCustomer();
        }

        private void VerifyCustomerDetails()
        {
            Console.WriteLine("Customer details verified");
        }

        private void VerifyOrderDetails()
        {
            Console.WriteLine("Order details verified");
        }

        public abstract void ShipOrder();

        public abstract void UpdateToCustomer();
    }
}
