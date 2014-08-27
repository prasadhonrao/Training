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
            var number1 = int.Parse(args[0]);
            var number2 = int.Parse(args[1]);

            Task<int> T = Task.Factory.StartNew<int>(() =>
            {
                return Divide(number1, number2);
            });

            try
            {
                Console.WriteLine("Division Result {0}", T.Result);
            }
            catch (AggregateException ae)
            {
                Console.WriteLine(ae.InnerException.Message);
            }

            Console.Read();
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
