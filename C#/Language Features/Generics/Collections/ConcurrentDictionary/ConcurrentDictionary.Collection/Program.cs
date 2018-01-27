using System;
using System.Collections.Concurrent;

namespace ConcurrentDictionary.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new ConcurrentDictionary<string, int>();

            #region Add
            // Try Add is thread safe method
            stock.TryAdd("Levis", 100);
            stock.TryAdd("Killer", 35);
            stock.TryAdd("Mufti", 75);

            Console.WriteLine("Available stock");
            foreach (var item in stock)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
            #endregion

            #region Add Duplicate

            // Try to add duplicate key
            var success = stock.TryAdd("Killer", 10);
            Console.WriteLine("TryAdd succeeded? {0}", success);

            Console.WriteLine();

            #endregion

            #region Remove
            
            // TryRemove
            int levis;
            var levisRemoved = stock.TryRemove("Levis", out levis);
            Console.WriteLine("Levis stock value {0}", levis);
            Console.WriteLine("Levis removed successfully? {0}", levisRemoved);

            #endregion

            Console.ReadLine();
        }
    }
}
