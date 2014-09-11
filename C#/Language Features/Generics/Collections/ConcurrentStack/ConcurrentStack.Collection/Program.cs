using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentStack.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            int errorCount = 0;

            // Construct a ConcurrentStack
            var cs = new ConcurrentStack<int>();

            // Push some elements onto the stack
            cs.Push(1);
            cs.Push(2);

            int concurrentStackResult;

            // Peek at the top of the stack 
            if (!cs.TryPeek(out concurrentStackResult))
            {
                Console.WriteLine("CS: TryPeek() failed when it should have succeeded");
                errorCount++;
            }
            else if (concurrentStackResult != 2)
            {
                Console.WriteLine("CS: TryPeek() saw {0} instead of 2", concurrentStackResult);
                errorCount++;
            }

            // Pop a number off of the stack 
            if (!cs.TryPop(out concurrentStackResult))
            {
                Console.WriteLine("CS: TryPop() failed when it should have succeeded");
                errorCount++;
            }
            else if (concurrentStackResult != 2)
            {
                Console.WriteLine("CS: TryPop() saw {0} instead of 2", concurrentStackResult);
                errorCount++;
            }

            // Clear the stack, and verify that it is empty
            cs.Clear();
            if (!cs.IsEmpty)
            {
                Console.WriteLine("CS: IsEmpty not true after Clear()");
                errorCount++;
            }

            if (errorCount == 0) Console.WriteLine("  OK!");

            Console.ReadLine();
        }
    }
}
