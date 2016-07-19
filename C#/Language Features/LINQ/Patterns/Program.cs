using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var orders = Order.GetSampleData();

            GetDelieveredOrderWithoutLINQ(orders);
            GetDeliveredOrderWithLINQExpression(orders);
            GetDeliveredOrderWithLINQQuery(orders);

            Console.ReadLine();
        }

        private static void GetDeliveredOrderWithLINQQuery(List<Order> orders)
        {
            (from o in orders
             where o.Status.Equals("Delivered")
             select o).ToList().ForEach(o => PrintOrder(o));

        }

        private static void GetDeliveredOrderWithLINQExpression(List<Order> orders)
        {
            orders.Where(o => o.Status.Equals("Delivered")).ToList().ForEach(o => PrintOrder(o));
        }

        private static void GetDelieveredOrderWithoutLINQ(List<Order> orders)
        {
            foreach (var order in orders)
            {
                if (order.Status.Equals("Delivered"))
                {
                    PrintOrder(order);
                }
            }
        }

        private static void PrintOrder(Order order)
        {
            Console.WriteLine("Order Id : {0}, Customer : {1}, Status : {2}", order.Id, order.CustomerName, order.Status);
        }
    }

    public class Order
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string CustomerName { get; set; }
        public string Status { get; set; }


        public static List<Order> GetSampleData()
        {
            return new List<Order>
            {
                new Order { Id =1, CustomerName ="Prasad" , Amount = 99.99m, Status ="Delivered" },
                new Order { Id =2, CustomerName ="Anil" , Amount = 59.50m, Status ="Pending" },
                new Order { Id =3, CustomerName ="Rita" , Amount = 59.50m, Status ="Refunded" },
                new Order { Id =4, CustomerName ="Girish" , Amount = 59.50m, Status ="Delivered" },
                new Order { Id =5, CustomerName ="Deepa" , Amount = 59.50m, Status ="Refunded" },
            };
        }
    }
}
