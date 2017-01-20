using System;
using static System.Console;

namespace _3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(WithIComparable("x"));
            WriteLine(WithIComparable(10));
            WriteLine(WithIComparable(0));
            WriteLine(WithIComparable(-10));
            WriteLine(WithIComparable(DateTime.MinValue));


            WriteLine("*******************");
            WriteLine(WithIEquatable("x"));
            WriteLine(WithIEquatable(10));
            WriteLine(WithIEquatable(0));
            WriteLine(WithIEquatable(-10));
            WriteLine(WithIEquatable(DateTime.MinValue));

            Console.ReadLine();
        }

        static int WithIComparable<T>(T value) where T : IComparable<T>
        {
            return value.CompareTo(default(T));
        }

        static bool WithIEquatable<T>(T value) where T : IEquatable<T>
        {
            return value.Equals(default(T));
        }
    }
}
