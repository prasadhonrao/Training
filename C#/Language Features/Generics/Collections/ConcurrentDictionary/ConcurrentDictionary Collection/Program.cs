using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUMITEMS = 64;
            int initialCapacity = 101;

            // The higher the concurrencyLevel, the higher the theoretical number of operations 
            // that could be performed concurrently on the ConcurrentDictionary.  However, global 
            // operations like resizing the dictionary take longer as the concurrencyLevel rises.  
            // For the purposes of this example, we'll compromise at numCores * 2. 
            int numProcs = Environment.ProcessorCount;
            int concurrencyLevel = numProcs * 2;

            // Construct the dictionary with the desired concurrencyLevel and initialCapacity
            var cd = new ConcurrentDictionary<int, int>(concurrencyLevel, initialCapacity);

            // Initialize the dictionary 
            for (int i = 0; i < NUMITEMS; i++) cd[i] = i * i;

            Console.WriteLine("The square of 23 is {0} (should be {1})", cd[23], 23 * 23);

            Console.ReadLine();
        }
    }
}
