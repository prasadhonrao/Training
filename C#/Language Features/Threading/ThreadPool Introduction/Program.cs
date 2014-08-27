using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPool_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Main thread with Id {0}", Thread.CurrentThread.ManagedThreadId);

            for (int i = 1; i <= 10; i++)
            {
                ThreadPool.QueueUserWorkItem(PrintMessage, i);
            }

            Thread.Sleep(rand.Next(100, 500));
            Console.WriteLine("Ending Main thread with Id {0}", Thread.CurrentThread.ManagedThreadId);

            Console.ReadLine();
        }

        static Random rand = new Random();

        private static void PrintMessage(object state)
        {
            Thread.Sleep(rand.Next(100, 500));
            // Uses thread from pool, so execution order may differ for different runs
            Console.WriteLine("Hello World Id {0} : Thread Id {1}", state, Thread.CurrentThread.ManagedThreadId);
        }
    }
}
