using System;

namespace _3._4
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


            Console.WriteLine("*******************");
            Console.WriteLine(CompareToDefaultUsingIEquatable("x"));
            Console.WriteLine(CompareToDefaultUsingIEquatable(10));
            Console.WriteLine(CompareToDefaultUsingIEquatable(0));
            Console.WriteLine(CompareToDefaultUsingIEquatable(-10));
            Console.WriteLine(CompareToDefaultUsingIEquatable(DateTime.MinValue));

            Console.ReadLine();
        }

        static int CompareToDefault<T>(T value) where T : IComparable<T>
        {
            return value.CompareTo(default(T));
        }

        static bool CompareToDefaultUsingIEquatable<T>(T value) where T : IEquatable<T>
        {
            return value.Equals(default(T));
        }
    }
}
