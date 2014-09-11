using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Performance
{
    class Program
    {
        const int Counter = 20000000;

        static void Main()
        {
            ExecuteNonGeneric();
            ExecuteGeneric();
            Console.ReadLine();
        }

        public static void ExecuteNonGeneric()
        {
            var watch = new Stopwatch();
            watch.Start();

            var items = new ArrayList(Counter);

            for (int i = 0; i < Counter; i++)
            {
                items.Add(i);
            }

            foreach (var item in items)
            {
                int temp = (int)item;
            }

            watch.Stop();
            Console.WriteLine("Non Generic method took {0} ms to execute", watch.ElapsedMilliseconds);
        }

        public static void ExecuteGeneric()
        {
            var watch = new Stopwatch();
            watch.Start();

            var items = new List<int>(Counter);

            for (int i = 0; i < Counter; i++)
            {
                items.Add(i);
            }

            foreach (var item in items)
            {
                int temp = item;
            }

            watch.Stop();
            Console.WriteLine("Generic method took {0} ms to execute", watch.ElapsedMilliseconds);
        }
    }
}
