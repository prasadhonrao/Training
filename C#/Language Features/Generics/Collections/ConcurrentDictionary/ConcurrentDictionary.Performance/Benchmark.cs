using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentDictionary.Performance
{
    public class Benchmark
    {
        public static void Add(IDictionary<int, int> dictionary, int size)
        {
            for (int i = 0; i < size; i++)
            {
                dictionary.Add(i, i);
            }

            for (int i = 0; i < size; i++)
            {
                dictionary[i] = i + 1;
            }
        }
    }
}
