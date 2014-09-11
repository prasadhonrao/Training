using System;
using System.Collections.Generic;

namespace LinkedList.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberLinkedList = new LinkedList<int>();
            numberLinkedList.AddFirst(1);  // 1

            var first = numberLinkedList.First;
            numberLinkedList.AddAfter(first, 2); // 1, 2

            numberLinkedList.AddAfter(numberLinkedList.Last, 3); // 1,2,3
            numberLinkedList.AddBefore(numberLinkedList.First, 0); // 0,1,2,3

            Console.WriteLine("LinkedList count {0}", numberLinkedList.Count);
            Console.WriteLine("Number LinkedList contents");
            foreach (var item in numberLinkedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Removing first item from LinkedList");
            numberLinkedList.RemoveFirst();
            Console.WriteLine("LinkedList count {0}", numberLinkedList.Count);
            Console.WriteLine("Number LinkedList contents");
            foreach (var item in numberLinkedList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
