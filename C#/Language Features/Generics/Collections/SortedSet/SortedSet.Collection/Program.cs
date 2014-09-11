using System;
using System.Collections.Generic;
using System.Linq;

namespace SortedSet.Collection
{
    class Program
    {
        // Same as HashSet except in sorted format
        static void Main(string[] args)
        {
            var numberSortedSet = new SortedSet<int>();

            numberSortedSet.Add(30);
            numberSortedSet.Add(50);
            numberSortedSet.Add(3);
            numberSortedSet.Add(10);

            Console.WriteLine("List count {0}", numberSortedSet.Count);

            Console.WriteLine("SortedSet contents");
            foreach (var item in numberSortedSet)
            {
                Console.WriteLine(item);
            }

            var firstMemberInSortedSet = numberSortedSet.First();
            Console.WriteLine("First member in SortedSet {0}", firstMemberInSortedSet);

            Console.WriteLine("Removing first item from the SortedSet");
            numberSortedSet.Remove(numberSortedSet.First());

            Console.WriteLine("Number of remaining items in List {0}", numberSortedSet.Count);
            Console.WriteLine("SortedSet contents");
            foreach (var item in numberSortedSet)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
