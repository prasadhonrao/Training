using System;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task T1 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("First Task Completed");
            });

            Task T2 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Second Task Completed");
            });

            Task T3 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Third Task Completed");
            });


            Task[] tasks = { T1, T2, T3 }; // Even though the tasks are added in specific order, its execution order is indeterministic as they run in parallel.

            Task.WaitAll(tasks);

            Console.WriteLine("All the tasks completed");
            Console.Read();
        }
    }
}
