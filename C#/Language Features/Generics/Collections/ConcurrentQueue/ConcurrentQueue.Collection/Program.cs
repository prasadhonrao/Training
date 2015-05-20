using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrentQueue.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            var orders = new ConcurrentQueue<string>();
            Console.WriteLine("*** Single thread environment ***");
            PlaceOrder(orders, "Mark");
            PlaceOrder(orders, "Steve");
            PlaceOrder(orders, "Adam");

            foreach (var order in orders)
            {
                Console.WriteLine("ORDER : " + order);
            }

            Console.WriteLine("*** Multithreaded environment ***");
            orders = new ConcurrentQueue<string>();
            
            // Unexpected results if run on multiple threads
            Task task1 = Task.Run(() => PlaceOrder(orders, "Jack"));
            Task task2 = Task.Run(() => PlaceOrder(orders, "Pete"));
            Task task3 = Task.Run(() => PlaceOrder(orders, "Andy"));
            Task.WaitAll(task1, task2, task3);

            foreach (var order in orders)
            {
                Console.WriteLine("ORDER : " + order);
            }

            Console.ReadLine();
        }

        static void PlaceOrder(ConcurrentQueue<string> orders, string name)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1);
                var orderName = string.Format("{0} wants T-Shirt {1}", name, i);
                orders.Enqueue(orderName);
            }
        }
    }
}
