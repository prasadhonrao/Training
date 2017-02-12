using System;
using System.Threading;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task T1 = Task.Factory.StartNew(() => {
                Thread.Sleep(2000); Console.WriteLine("Task 1 completed");
            });

            Task T2 = T1.ContinueWith((t1) => {
                Console.WriteLine("Task T2 started after T1 completed");
            });

            Task T3 = Task.Factory.StartNew(() => {
                T2.Wait(); // Do NOT using this syntax for performance reason. Same thread can be utilized for multiple tasks.
                Console.WriteLine("Task 3 completed");
            });

            Console.Read();
        }
    }
}
