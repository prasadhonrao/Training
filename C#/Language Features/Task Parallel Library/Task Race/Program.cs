using System;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        // Starting two tasks in parallel, sharing common variable 'counter'. The value of variable cannot be determined as any of these tasks can run first.

        static void Main(string[] args)
        {
            int counter = 0;

            Task T1 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Executing task 1");
                counter = counter + 100;
            });

            Task T2 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Executing task 2");
                counter = counter + 9999;
            });

            Task[] tasks = { T1, T2 };
            Task.WaitAll(tasks);

            Console.WriteLine("Counter value : {0}", counter);
            Console.Read();
        }
    }
}
