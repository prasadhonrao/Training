using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            var query = from n in Enumerable.Range(1, 5) select n;
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            IAmDone();

            // Implementation using Observable
            var observableQuery = query.ToObservable();
            observableQuery.Subscribe(Console.WriteLine, IAmDone);

            Console.ReadLine();
        }

        static void IAmDone()
        {
            Console.WriteLine("I am done!");
        }
    }
}
