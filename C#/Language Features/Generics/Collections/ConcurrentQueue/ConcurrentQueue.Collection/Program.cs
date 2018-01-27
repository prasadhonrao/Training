using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrentQueue.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Single Thread Queue

            //var orders = new Queue<string>();
            //Console.WriteLine("*** Single Threaded Queue Environment ***");
            //PlaceOrder(orders, "Mark");
            //PlaceOrder(orders, "Steve");
            //PlaceOrder(orders, "Adam");

            //foreach (var order in orders)
            //{
            //    Console.WriteLine("ORDER : " + order);
            //}

            #endregion


            #region Multi Thread Queue

            var orders2 = new Queue<string>();
            Console.WriteLine("*** Multi Threaded Queue Environment ***");

            // BEWARE OF DATA LOSS SINCE QUEUE CLASS IS BEST SUITED FOR SINGLE THREDED ENVIRONMENT

            Task task1 = Task.Run(() => PlaceOrder(orders2, "Mark")); 
            Task task2 = Task.Run(() => PlaceOrder(orders2, "Steve"));
            Task task3 = Task.Run(() => PlaceOrder(orders2, "Adam"));
            Task.WaitAll(task1, task2, task3);

            foreach (var order in orders2)
            {
                Console.WriteLine("ORDER : " + order);
            }

            #endregion


            #region Single Thread Concurrent Queue
            //var concurrentOrders = new ConcurrentQueue<string>();
            //Console.WriteLine("*** Single threaded environment ***");
            //PlaceOrder(orders, "Mark");
            //PlaceOrder(orders, "Steve");
            //PlaceOrder(orders, "Adam");

            //foreach (var order in concurrentOrders)
            //{
            //    Console.WriteLine("Concurrent Order : " + order);
            //}
            #endregion

            #region Multithreaded Concurrent Queue
            //Console.WriteLine("*** Multithreaded environment ***");
            //var concurrentOrders = new ConcurrentQueue<string>();

            //// Unexpected results if run on multiple threads
            //Task task1 = Task.Run(() => PlaceOrder(concurrentOrders, "Mark"));
            //Task task2 = Task.Run(() => PlaceOrder(concurrentOrders, "Steve"));
            //Task task3 = Task.Run(() => PlaceOrder(concurrentOrders, "Adam"));
            //Task.WaitAll(task1, task2, task3);

            //foreach (var order in concurrentOrders)
            //{
            //    Console.WriteLine("Concurrent Order : " + order);
            //}
            #endregion

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
