using System;
using System.Collections.Immutable;
using System.Linq;

namespace ImmutableQueue.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            var emplyeeIQueue = ImmutableQueue<string>.Empty;
            emplyeeIQueue = emplyeeIQueue.Enqueue("Prasad");
            emplyeeIQueue = emplyeeIQueue.Enqueue("Amit");
            emplyeeIQueue = emplyeeIQueue.Enqueue("Scott");

            Console.WriteLine("Employee Queue count {0}", emplyeeIQueue.Count());

            foreach (var item in emplyeeIQueue)
            {
                Console.WriteLine(item);
            }

            string firstEmployee = string.Empty;
            emplyeeIQueue = emplyeeIQueue.Dequeue(out firstEmployee);
            Console.WriteLine("First number in queue {0}", firstEmployee);

            Console.WriteLine("Number of remaining items in queue {0}", emplyeeIQueue.Count());

            Console.ReadLine();
        }
    }
}
