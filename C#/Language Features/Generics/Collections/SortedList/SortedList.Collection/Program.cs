using System;
using System.Collections.Generic;
using System.Linq;

namespace SortedList.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Flexible collection in sorted key format

            var numberSortedList = new SortedList<int, string>();

            numberSortedList.Add(30, "Thirty");
            numberSortedList.Add(50, "Fifty");
            numberSortedList.Add(3, "Three");
            numberSortedList.Add(10, "Ten");

            Console.WriteLine("List count {0}", numberSortedList.Count);

            Console.WriteLine("SortedLiest contents");
            foreach (var item in numberSortedList)
            {
                Console.WriteLine(item);
            }

            var firstMemberInSortedList = numberSortedList.First();
            Console.WriteLine("First member in List {0}", firstMemberInSortedList);

            Console.WriteLine("Removing first item from the List");
            numberSortedList.Remove(numberSortedList.First().Key);

            Console.WriteLine("Number of remaining items in List {0}", numberSortedList.Count);
            Console.WriteLine("Number List contents");
            foreach (var item in numberSortedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
