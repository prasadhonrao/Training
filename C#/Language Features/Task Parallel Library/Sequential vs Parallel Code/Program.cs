using System;
using System.Threading.Tasks;

namespace Sequential_vs_Parallel_Code
{
    class Program
    {
        const int ITERATIONS = 5;
        static void Main(string[] args)
        {
            RunSequential();
            Console.WriteLine();
            RunParallel();

            Console.ReadLine();
        }
        private static void RunSequential()
        {
            Console.WriteLine("Sequential execution start...");
            PrintFirst();
            PrintSecond();
            PrintThird();
            Console.WriteLine("Sequential execution end...");
        }

        private static void RunParallel()
        {
            Console.WriteLine("Parallel execution start...");
            Task.Factory.StartNew(() =>
            {
                PrintFirst();
                PrintSecond();
                PrintThird();
            });
            Console.WriteLine("Parallel execution end...");
        }


        static void PrintFirst()
        {
            for (int i = 0; i < ITERATIONS; i++)
            {
                Console.Write("\t First");
            }
            Console.WriteLine();
        }
        static void PrintSecond()
        {
            for (int i = 0; i < ITERATIONS; i++)
            {
                Console.Write("\t Second");
            }
            Console.WriteLine();
        }
        static void PrintThird()
        {
            for (int i = 0; i < ITERATIONS; i++)
            {
                Console.Write("\t Third");
            }
            Console.WriteLine();
        }
    }

}
