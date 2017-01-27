using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns
{
    class Program
    {
        static List<Order> orders = new List<Order>();

        static void Main(string[] args)
        {

            orders = Order.GetSampleData();

            #region Where Pattern
            FindAllDeliveredOrders();
            FindAllDeliveredOrdersExpression();
            FindAllDeliveredOrdersQuery();
            #endregion

            #region Find First Pattern
            FindFirstRefundedOrder();
            FindFirstRefundedOrderExpression();
            FindFirstRefundedOrderQuery();
            #endregion

            #region All True Pattern

            // Find if all the items are refunded
            CheckIfAllItemsDelivered();
            CheckIfAllItemsDeliveredExpression();

            //Count refunded orders
            CountRefundedOrders();
            CountRefundedOrdersExpression();

            #endregion

            #region Chaining Pattern
            ChainingPattern();
            DoubleItAndDisplayDescending();
            #endregion

            // Distinct across multiple columns
            GetDistinctDataAcrossMultipleColumns();
            
            Console.ReadLine();
        }

        private static void DoubleItAndDisplayDescending()
        {
            "10, 20, 30, 40, 50, 40, 30, 20, 10"
            .Split(',')
            .Select(int.Parse)
            .Select(n => n * 2)
            .OrderByDescending(n => n)
            .ToList()
            .ForEach(n => Console.WriteLine(n));
           
        }

        private static void ChainingPattern()
        {
            // Calculate sum of numbers in the series excluding 3 min numbers
            var sum = "10, 20, 30, 40, 50, 40, 30, 20, 10"
                .Split(',')
                .Select(int.Parse)
                .OrderBy(n => n)
                .Skip(3)
                .Sum();

            Console.WriteLine("Sum is = " + sum);
        }

        private static void GetDistinctDataAcrossMultipleColumns()
        {
            orders = new List<Order>
            {
                new Order { Id =1, CustomerName ="Prasad" , Amount = 99.99m, Status ="Delivered" },
                new Order { Id =2, CustomerName ="Anil" , Amount = 59.50m, Status ="Pending" },
                new Order { Id =3, CustomerName ="Rita" , Amount = 59.50m, Status ="Refunded" },
                new Order { Id =4, CustomerName ="Girish" , Amount = 59.50m, Status ="Delivered" },
                new Order { Id =5, CustomerName ="Deepa" , Amount = 59.50m, Status ="Refunded" },
                new Order { Id =6, CustomerName ="Sbeha" , Amount = 159.50m, Status ="Pending" },
                new Order { Id =1, CustomerName ="Prasad" , Amount = 99.99m, Status ="Delivered" },
                new Order { Id =3, CustomerName ="Rita" , Amount = 59.50m, Status ="Refunded" },
            };

            var distinctOrders = orders.Select(m => new { m.Id, m.CustomerName, m.Amount })
                                .Distinct().ToList();

            distinctOrders.ForEach(o => Console.WriteLine("Order Number " + o.Id));

        }

        private static void CountRefundedOrdersExpression()
        {
            var refundedOrderCount = orders.Count(o => o.Status == "Refunded");
            Console.WriteLine("Total number of refunded orders " + refundedOrderCount);
        }

        private static void CountRefundedOrders()
        {
            int refundedOrderCount = 0;
            foreach (var order in orders)
            {
                if (order.Status == "Refunded")
                {
                    refundedOrderCount++;
                }
            }

            Console.WriteLine("Total number of refunded orders " + refundedOrderCount);
        }

        private static void CheckIfAllItemsDeliveredExpression()
        {
            bool isAllRefunded = orders.All(o => o.Status == "Delivered");
            if (isAllRefunded)
                Console.WriteLine("All the orders are delivered");
            else
                Console.WriteLine("Not all the orders are delivered yet");
        }

        private static void CheckIfAllItemsDelivered()
        {
            bool isAllRefunded = true;
            foreach (var order in orders)
            {
                if (order.Status != "Delivered")
                {
                    isAllRefunded = false;
                    break;
                }
            }

            if (isAllRefunded)
                Console.WriteLine("All the orders are delivered");
            else
                Console.WriteLine("Not all the orders are delivered yet");
        }

        private static void FindFirstRefundedOrderQuery()
        {
            var refundedItem = (from o in orders
                                where o.Status.Equals("Refunded")
                                select o).First();
            PrintOrder(refundedItem);
        }

        private static void FindFirstRefundedOrderExpression()
        {
            PrintOrder(orders.Where(o => o.Status.Equals("Refunded")).First());
        }

        private static void FindFirstRefundedOrder()
        {
            foreach (var order in orders)
            {
                if (order.Status.Equals("Refunded"))
                {
                    PrintOrder(order);
                    break;
                }
            }
        }

        private static void FindAllDeliveredOrdersQuery()
        {
            (from o in orders
             where o.Status.Equals("Delivered")
             select o).ToList().ForEach(o => PrintOrder(o));

        }

        private static void FindAllDeliveredOrdersExpression()
        {
            orders.Where(o => o.Status.Equals("Delivered")).ToList().ForEach(o => PrintOrder(o));
        }

        private static void FindAllDeliveredOrders()
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

}
