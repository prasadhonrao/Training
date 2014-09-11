using System;
using System.Collections.Generic;

namespace List.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList = new List<int>();
            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);

            Console.WriteLine("List count {0}", numberList.Count);

            Console.WriteLine("Number List contents");
            foreach (var item in numberList)
            {
                Console.WriteLine(item);
            }

            var firstNumberInList = numberList[0];
            Console.WriteLine("First number in List {0}", firstNumberInList);

            Console.WriteLine("Removing first item from the List");
            numberList.RemoveAt(0);

            Console.WriteLine("Number of remaining items in List {0}", numberList.Count);
            Console.WriteLine("Number List contents");
            foreach (var item in numberList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
