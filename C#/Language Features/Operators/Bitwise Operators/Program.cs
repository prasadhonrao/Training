using System;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 10; //1010

            // left shift by 2 bits
            var leftShift = number << 2; //101000
            Console.WriteLine(leftShift);

            // right shift by 2 bits
            var rightShift = number >> 2; //0010
            Console.WriteLine(rightShift);
        }
    }
}
