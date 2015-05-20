using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Queue.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberQueue = new Queue<int>();
            numberQueue.Enqueue(1);
            numberQueue.Enqueue(2);
            numberQueue.Enqueue(3);

            Console.WriteLine("Queue count {0}", numberQueue.Count);
            Console.WriteLine("Number queue contents");
            foreach (var item in numberQueue)
            {
                Console.WriteLine(item);
            }

            var firstNumber = numberQueue.Dequeue();
            Console.WriteLine("First number in queue {0}", firstNumber);
            Console.WriteLine("Number of remaining items in queue {0}", numberQueue.Count);

            // Queues is not threadsafe. For threadsafe queue use ConcurrentQueue or ImmutableQueue
            var orders = new Queue<string>();
            Console.WriteLine("*** Single thread environment ***");
            PlaceOrder(orders, "Mark");
            PlaceOrder(orders, "Steve");

            foreach (var order in orders)
            {
                Console.WriteLine("ORDER : " + order);
            }

            orders.Clear();
            Console.WriteLine("*** Multithreaded environment ***");

            // Unexpected results if run on multiple threads
            Task task1 = Task.Run(() => PlaceOrder(orders, "Jack"));
            Task task2 = Task.Run(() => PlaceOrder(orders, "Pete"));
            Task.WaitAll(task1, task2);

            foreach (var order in orders)
            {
                Console.WriteLine("ORDER : " + order);
            }

            Console.ReadLine();
        }

        static void PlaceOrder(Queue<string> orders, string name)
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
