using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        // Uninitialized enum variable will always point to enum with value 0. 
        // If enums are not defined with value, first item is considered at 0th location.

        static RainbowColors rainbow1;
        static RainbowColors rainbow2 = RainbowColors.Indigo;

        static void Main(string[] args)
        {
            Console.WriteLine(rainbow1);
            Console.WriteLine(rainbow2);
            Console.ReadLine();
        }
    }

    enum RainbowColors
    {
        Red = 10,
        Orange = 20,
        Yellow = 30,
        Green = 40,
        Blue = 50,
        Indigo = 60,
        Voilet = 70
    }
}
