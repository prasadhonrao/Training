using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionary.Collection
{
    // Flexible collection in sorted key format. Good for item insertion / deletion
    class Program
    {
        static void Main(string[] args)
        {
            var numberSortedDictionary = new SortedDictionary<int, string>();

            numberSortedDictionary.Add(30, "Thirty");
            numberSortedDictionary.Add(50, "Fifty");
            numberSortedDictionary.Add(3, "Three");
            numberSortedDictionary.Add(10, "Ten");

            Console.WriteLine("List count {0}", numberSortedDictionary.Count);

            Console.WriteLine("SortedDictionary contents");
            foreach (var item in numberSortedDictionary)
            {
                Console.WriteLine(item);
            }

            var firstMemberInSortedDictionary = numberSortedDictionary.First();
            Console.WriteLine("First member in List {0}", firstMemberInSortedDictionary);

            Console.WriteLine("Removing first item from the List");
            numberSortedDictionary.Remove(numberSortedDictionary.First().Key);

            Console.WriteLine("Number of remaining items in List {0}", numberSortedDictionary.Count);
            Console.WriteLine("Number List contents");
            foreach (var item in numberSortedDictionary)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
