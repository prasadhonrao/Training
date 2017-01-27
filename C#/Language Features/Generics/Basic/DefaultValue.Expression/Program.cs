using System;

namespace DefaultValue.Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CompareToDefault("x"));
            Console.WriteLine(CompareToDefault(10));
            Console.WriteLine(CompareToDefault(0));
            Console.WriteLine(CompareToDefault(-10));
            Console.WriteLine(CompareToDefault(DateTime.MinValue));

            Console.ReadLine();
        }

        static int CompareToDefault<T>(T value) where T : IComparable<T>
        {
            return value.CompareTo(default(T));
        }
    }
}
