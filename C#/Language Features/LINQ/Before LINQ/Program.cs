using System;
using System.Collections.Generic;
using System.Linq;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new[] { "Mumbai", "London", "Paris", "New York", "Tokyo", "Sydney", "Las Vegas" };
            IEnumerable<string> citiesStartsWithL;

            #region Anonymous Method
            Console.WriteLine("Anonymous Method");
            citiesStartsWithL = cities.Where(delegate(string s)
            {
                return s.StartsWith("L");
            });
            Print(citiesStartsWithL);
            Console.WriteLine();
            #endregion

            #region Named Method
            Console.WriteLine("Named Method");
            citiesStartsWithL = cities.Where(StartsWithL);
            Print(citiesStartsWithL);
            Console.WriteLine();
            #endregion

            Console.ReadLine();
        }

        private static bool StartsWithL(string city)
        {
            return city.StartsWith("L");
        }

        private static void Print(IEnumerable<string> cities)
        {
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
