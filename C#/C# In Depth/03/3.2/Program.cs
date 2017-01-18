using System;
using System.Collections.Generic;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>() { 1, 2, 3, 4, 5 };

            Converter<int, double> converter = TakeSquareRoot;
            List<double> doubles = integers.ConvertAll(converter);

            foreach (double d in doubles)
            {
                Console.WriteLine(d);
            }
            Console.ReadLine();
        }

        static double TakeSquareRoot(int x)
        {
            return Math.Sqrt(x);
        }

    }
}
