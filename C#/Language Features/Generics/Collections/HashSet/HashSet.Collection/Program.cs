using System;
using System.Collections.Generic;
using System.Linq;

namespace HashSet.Collection
{
    class Program
    {
        // HashSet collection doesn't allow duplicate values

        static void Main(string[] args)
        {
            var numberHashSet = new HashSet<int>();
            numberHashSet.Add(1);
            numberHashSet.Add(2);
            numberHashSet.Add(3);
            numberHashSet.Add(3);  // this call will be ignored

            Console.WriteLine("HashSet count {0}", numberHashSet.Count);

            Console.WriteLine("Number HashSet contents");
            foreach (var item in numberHashSet)
            {
                Console.WriteLine(item);
            }

            var firstNumberInHashSet = numberHashSet.First();
            Console.WriteLine("First number in HashSet {0}", firstNumberInHashSet);

            Console.WriteLine("Removing first item from the HashSet");
            numberHashSet.Remove(numberHashSet.First());

            Console.WriteLine("Number of remaining items in HashSet {0}", numberHashSet.Count);

            Console.WriteLine("Number HashSet contents");
            foreach (var item in numberHashSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
