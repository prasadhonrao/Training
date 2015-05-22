using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentDictionary.Performance
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = 1000000;
            var dictionary = new Dictionary<int, int>();
            var concurrent = new ConcurrentDictionary<int, int>();
            
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Benchmark.Add(dictionary, size);
            watch.Stop();
            var dictionaryTime = watch.ElapsedMilliseconds;
            Console.WriteLine("Ellapsed time for Dictionary {0}", dictionaryTime);

            watch.Reset();
            watch.Start();
            Benchmark.Add(concurrent, size);
            watch.Stop();
            var concurrentTime = watch.ElapsedMilliseconds;
            Console.WriteLine("Ellapsed time for ConcurrentDictionary {0}", concurrentTime);

            Console.ReadLine();
        }
    }
}
