using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> TList = new List<Task>();

            for (int i = 0; i < 10; i++)
            {
                Task<double> t = Task.Factory.StartNew<double>(() => { return Factorial(i); });
                TList.Add(t);
                Console.WriteLine("Factorial of {0} is {1}", i, t.Result);
            }

            Console.Read();
        }

        static double Factorial(int number)
        {
            double fact = 1;
            while (number > 0)
            {
                fact = fact * number;
                number--;
            }

            return fact;
        }
    }
}
