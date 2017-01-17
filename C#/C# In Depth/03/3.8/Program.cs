using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeWithField<int>.field = "First";
            TypeWithField<string>.field = "Second";
            TypeWithField<DateTime>.field = "Third";

            TypeWithField<int>.PrintField();
            TypeWithField<string>.PrintField();
            TypeWithField<DateTime>.PrintField();

        }
    }

    class TypeWithField<T>
    {
        public static string field;
        public static void PrintField()
        {
            Console.WriteLine(field + ": " + typeof(T).Name);
        }
    }
}
