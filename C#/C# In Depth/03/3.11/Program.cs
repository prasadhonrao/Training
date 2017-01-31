using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            DemonstrateTypeof<int>();

            Console.ReadLine();
        }

        static void DemonstrateTypeof<X>()
        {
            Console.WriteLine(typeof(X));
            Console.WriteLine(typeof(List<>));
            Console.WriteLine(typeof(Dictionary<,>));
            Console.WriteLine(typeof(List<X>));
            Console.WriteLine(typeof(Dictionary<string, X>));
            Console.WriteLine(typeof(List<long>));
            Console.WriteLine(typeof(List<DateTime>));
            Console.WriteLine(typeof(Dictionary<long, Guid>));
            Console.WriteLine(typeof(Tuple<,,,>));
            Console.WriteLine(typeof(Tuple<X, X>));
            Console.WriteLine(typeof(SortedDictionary<X, X>));
        }
    }
}
