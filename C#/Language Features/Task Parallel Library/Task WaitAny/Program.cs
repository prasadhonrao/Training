using System;
using System.Threading;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task T1 = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
            });

            Task T2 = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
            });

            Task T3 = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
            });


            Task[] tasks = { T1, T2, T3 }; // Even though the tasks are added in specific order, its execution order is indeterministic as they run in parallel.

            int index = Task.WaitAny(tasks);

            switch (index)
            {
                case 0:
                    Console.WriteLine("First task completed");
                    break;
                case 1:
                    Console.WriteLine("Second task completed");
                    break;
                case 2:
                    Console.WriteLine("Third task completed");
                    break;
                default:
                    break;
            }

            Console.Read();
        }
    }
}
