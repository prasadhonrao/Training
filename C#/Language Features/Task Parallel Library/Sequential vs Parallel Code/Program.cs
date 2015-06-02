using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequential_vs_Parallel_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunSequential();
            RunParallel();

            Console.ReadLine();
        }

        private static void RunParallel()
        {
            Task.Factory.StartNew(() =>
            {
                PrintFirst();
                PrintSecond();
                PrintThird();
            });
        }

        private static void RunSequential()
        {
            PrintFirst();
            PrintSecond();
            PrintThird();
        }

        static void PrintFirst()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.Write("\t First");
            }
        }
        static void PrintSecond()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.Write("\t Second");
            }
        }
        static void PrintThird()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.Write("\t Third");
            }
        }
    }

}
