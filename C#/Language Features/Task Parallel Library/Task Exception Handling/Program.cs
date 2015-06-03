using System;
using System.Threading.Tasks;

namespace Training.CSharp
{
    // Task exceptions are thrown using AggregateException
    class Program
    {
        static void Main(string[] args)
        {
            HandleErrorUsingException();
            HandleErrorUsingAggregateException();

            Console.ReadLine();
        }

        private static void HandleErrorUsingException()
        {
            var number1 = 10;
            var number2 = 0;

            Task<int> T = Task.Factory.StartNew<int>(() =>
            {
                return Divide(number1, number2);
            });

            try
            {
                Console.WriteLine("Division Result {0}", T.Result);
            }
            //catch (AggregateException ae)
            //{
            //    Console.WriteLine(ae.InnerException.Message);
            //}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void HandleErrorUsingAggregateException()
        {
            var number1 = 10;
            var number2 = 0;

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
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
