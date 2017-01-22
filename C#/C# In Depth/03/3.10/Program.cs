using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            CountingEnumerable counter = new CountingEnumerable();
            foreach (var item in counter)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }

    class CountingEnumerable : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return new CountingEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    internal class CountingEnumerator : IEnumerator<int>
    {
        int current = -1;
        public bool MoveNext()
        {
            current++;
            return current < 10;
        }

        public int Current { get { return current; } }

        object IEnumerator.Current { get { return Current; } }

        public void Reset()
        {
            current = -1;
        }

        public void Dispose()
        {
            Console.WriteLine("All the values are printed now!");
        }
    }
}
