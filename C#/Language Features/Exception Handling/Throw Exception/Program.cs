using System;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                NotImplementedOperation();
                DivideByZeroOperation();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Exiting main...");
            }
        }

        private static void DivideByZeroOperation()
        {
            try
            {
                int i = 2;
                int j = 0;
                Console.WriteLine(i / j);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Caught DivideByZeroException");
            }
        }

        private static void NotImplementedOperation()
        {
            try
            {
                DoWork();
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("NotImplementedException occurred");
            }
        }

        private static void DoWork()
        {
            throw new NotImplementedException();
        }
    }
}
