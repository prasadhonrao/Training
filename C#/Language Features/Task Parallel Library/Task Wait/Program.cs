using System;
using System.Threading;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task T = Task.Factory.StartNew(
                () =>
                {
                    DoWork();
                });

            T.Wait();
            Console.WriteLine("Task completed with status {0} ", T.Status);


            Task<int> T1 = Task.Factory.StartNew<int>(
                () =>
                {
                    int i = PrintNumber(1);
                    return i;
                });

            Console.WriteLine(T1.Result);

            Console.Read();

        }

        private static int PrintNumber(int number)
        {
            return number;
        }

        private static void DoWork()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Do Work completed");
        }
    }
}
