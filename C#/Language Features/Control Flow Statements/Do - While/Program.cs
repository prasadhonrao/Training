using System;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to calculate factorial : ");
            string input = Console.ReadLine();
            Console.WriteLine("{0} factorial is {1}", input, Factorial(Convert.ToInt32(input)));
            Console.ReadLine();
        }

        public static double Factorial(int input)
        {
            double fact = 1;
            do
            {
                fact = fact * input;
                input--;
            }
            while (input > 0);

            return fact;
        }
    }
}
