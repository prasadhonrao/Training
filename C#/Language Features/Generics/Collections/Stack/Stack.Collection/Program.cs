using System;
using System.Collections.Generic;

namespace Stack.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberStack = new Stack<int>();
            numberStack.Push(1);
            numberStack.Push(2);
            numberStack.Push(3);

            Console.WriteLine("Stack count {0}", numberStack.Count);

            Console.WriteLine("Number stack contents");
            foreach (var item in numberStack)
            {
                Console.WriteLine(item);
            }

            var firstNumberInStack = numberStack.Pop();
            Console.WriteLine("First number in queue {0}", firstNumberInStack);

            Console.WriteLine("Number of remaining items in queue {0}", numberStack.Count);

            Console.WriteLine("----");
        }
    }
}
