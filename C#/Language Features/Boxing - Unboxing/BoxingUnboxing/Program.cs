using System;
namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 100;

            object age = counter; // boxing

            DisplayValue(counter); // boxing

            Console.ReadLine();
        }

        public static void DisplayValue(object value)
        {
            int local = (int)value; //unboxing
        }
    }
}
