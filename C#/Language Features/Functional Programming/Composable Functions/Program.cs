using System;
using System.Collections.Generic;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var primeNumbers = Find(numbers, IsPrime);
            var evenNumbers = Find(numbers, IsEven);
            var oddNumbers = Find(numbers, IsOdd);
        }

        public static IEnumerable<int> Find(IEnumerable<int> input, Func<int, bool> condition)
        {
            var result = new List<int>();

            foreach (var item in input)
            {
                if (condition(item))
                    result.Add(item);
            }

            return result;
        }

        private static bool IsOdd(int number)
        {
            if (number % 2 == 1)
                return true;
            return false;
        }

        private static bool IsEven(int number)
        {
            if (number % 2 == 0)
                return true;
            return false;
        }

        private static bool IsPrime(int number)
        {
            var result = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }


}
