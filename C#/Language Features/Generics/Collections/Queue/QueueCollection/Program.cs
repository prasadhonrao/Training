using System;
using System.Collections.Generic;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberQueue = new Queue<int>();
            numberQueue.Enqueue(1);
            numberQueue.Enqueue(2);
            numberQueue.Enqueue(3);

            Console.WriteLine("Queue count {0}", numberQueue.Count);

            Console.WriteLine("Number queue contents");
            foreach (var item in numberQueue)
            {
                Console.WriteLine(item);
            }

            var firstNumber = numberQueue.Dequeue();
            Console.WriteLine("First number in queue {0}", firstNumber);

            Console.WriteLine("Number of remaining items in queue {0}", numberQueue.Count);

            Console.WriteLine("----");
        }
    }
}
