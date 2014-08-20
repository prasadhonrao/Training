using System;

namespace Training.CSharp
{
    class Program
    {
        static void Main()
        {
            PrintValues(1, 23);
            PrintValues("Hello", "World", "1", 2, 3, 4,true);
            Console.ReadLine();
        }

        private static void PrintValues(params object[] values)
        {
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
