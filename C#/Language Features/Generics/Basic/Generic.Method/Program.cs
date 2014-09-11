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
            foreach (var word in morningWords)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine(); 
            #endregion

            #region Compiler infering type info
            var nightWords = MakeList("Good", "Night!");
            foreach (var word in nightWords)
            {
                Console.Write(word + " ");
            } 
            #endregion

            #region ConvertAll int -> double
            // Generic method ConvertAll in List<T> class - converts from one datatype into another
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            var sqrts = numbers.ConvertAll<double>(e => Math.Sqrt(e));
            Dump<Double>(sqrts);
            // Dump(sqrts); Valid as compiler will infer the type 
            #endregion

            #region ConvertAll int -> string
            var numberAsStrings = numbers.ConvertAll<string>(e => e.ToString());
            Dump(numberAsStrings); 
            #endregion

            Console.ReadLine();
        }

        private static List<T> MakeList<T>(T first, T second)
        {
            List<T> newlist = new List<T>();
            newlist.Add(first);
            newlist.Add(second);
            return newlist;
        }

        private static void Dump<T>(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
