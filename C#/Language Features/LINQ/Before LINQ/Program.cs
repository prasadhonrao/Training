using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new[] { "Mumbai", "London", "Paris", "New York", "Tokyo", "Sydney", "Las Vegas" };
            IEnumerable<string> citiesStartsWithL;

            #region Regex and query
            var names = new List<string>
            {
                "Prasad, Honrao",
                "Scott, Hanselman",
                "John, Cena",
                "Jon Skeet",
                "This is not a valid name",
                "Jack, Jill"
            };
            Console.WriteLine("Regex and query");
            Regex pattern = new Regex("([^,]*),(.*)");
            var query = from line in names
                        let match = pattern.Match(line)
                        where match.Success
                        select new
                        {
                            Name = match.Groups[1].Value,
                            Relationship = match.Groups[2].Value
                        };

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            #endregion
            
            #region Anonymous Method
            Console.WriteLine("Anonymous Method");
            citiesStartsWithL = cities.Where(delegate (string s)
            {
                return s.StartsWith("L");
            });
            Print(citiesStartsWithL);
            Console.WriteLine();
            #endregion

            #region Extension Method
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

        private static void Print(IEnumerable<string> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
