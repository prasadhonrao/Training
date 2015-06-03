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

            // Flatten the exception in exception tree
            try
            {
                HandleMultipleErrorsUsingAggregateException();
            }
            catch (AggregateException ae)
            {
                Console.WriteLine("Flattening exceptions");
                var errors = ae.Flatten();
                foreach (var error in errors.InnerExceptions)
                {
                    Console.WriteLine(error.Message);
                }
            }

            Console.ReadLine();
        }

        #region Exception flattening
        private static void HandleMultipleErrorsUsingAggregateException()
        {
            Task<int> T1 = FirstDivision();
            Task T2 = ThrowCustomException();
            Task.WaitAll(T1, T2);
        }
        private static Task<int> FirstDivision()
        {
            var number1 = 10;
            var number2 = 0;

            Task<int> T = Task.Factory.StartNew<int>(() =>
            {
                return number1 / number2;
            });
            return T;
        }
        private static Task ThrowCustomException()
        {
            return Task.Factory.StartNew(() => { throw new ApplicationException("appexception"); });
        }
        
        #endregion

        private static void HandleErrorUsingException()
        {
            var number1 = 10;
            var number2 = 0;

            Task<int> T = Task.Factory.StartNew<int>(() =>
            {
                return number1 / number2;
            });

            try
            {
                Console.WriteLine("Division Result {0}", T.Result);
            }
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
                return number1 / number2;
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
    }
}
