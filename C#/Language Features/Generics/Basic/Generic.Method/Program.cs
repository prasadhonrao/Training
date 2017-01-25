using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Method
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MakeList
            List<string> morningWords = MakeList<string>("Good", "Morning");
            DisplayContents(morningWords);
            Console.WriteLine();
            #endregion

            #region Compiler inference
            var nightWords = MakeList("Good", "Night!");
            DisplayContents(nightWords);
            #endregion

            #region ConvertAll int -> double
            // Generic method ConvertAll in List<T> class - converts from one data type into another
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            var sqrts = numbers.ConvertAll<double>(e => Math.Sqrt(e));
            DisplayContents<Double>(sqrts);
            // DisplayContents(sqrts); Valid as compiler will infer the type 
            #endregion

            #region ConvertAll int -> string
            var numberAsStrings = numbers.ConvertAll<string>(e => e.ToString());
            DisplayContents(numberAsStrings);
            #endregion

            DisplayContents<int>(new int[] { 1, 2, 3, 4, 5 });
            DisplayContents<char>(new List<char> { 'a', 'b', 'c' });

            Console.ReadLine();
        }

        private static List<T> MakeList<T>(T first, T second)
        {
            List<T> newlist = new List<T>();
            newlist.Add(first);
            newlist.Add(second);
            return newlist;
        }

        private static void DisplayContents<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
