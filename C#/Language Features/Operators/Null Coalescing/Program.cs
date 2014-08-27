using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ?? checks for null value

            var language = "C#";
            var result = language ?? "JavaScript";
            Console.WriteLine("My favorite language is {0}", result);

            language = null;
            result = language ?? "JavaScript";
            Console.WriteLine("My favorite language is {0}", result);

            
            // Chaining
            int? firstNumber = null;
            int? secondNumber = null;
            var thirdNumber = 100;

            var numberResult = firstNumber ?? secondNumber ?? thirdNumber;
            Console.WriteLine(numberResult);
            
            Console.Read();
        }
    }
}
