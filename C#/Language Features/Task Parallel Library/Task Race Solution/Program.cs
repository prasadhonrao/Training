using System;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            var door = new object();
            var obj1 = new Program();
            var obj2 = new Program();

            Task T1 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Executing task 1");
                int result = obj1.Compute();
                lock (door)
                {
                    counter = counter + result;
                }
            });

            Task T2 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Executing task 2");
                int result = obj2.Compute();
                lock (door)
                {
                    counter = counter + result;
                }
            });

            Task[] tasks = { T1, T2 };
            Task.WaitAll(tasks);

            Console.WriteLine("Counter value : {0}", counter);
            Console.Read();
        }

        int Compute()
        {
            return 100;
        }
    }
}
