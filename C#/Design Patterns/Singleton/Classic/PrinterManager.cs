using System;
namespace Singleton.Basic
{
    public sealed class PrinterManager
    {
        private static PrinterManager instance;

        private PrinterManager()
        {
            Console.WriteLine("Instance constructor");
        }

        // Constructor marked as private so client cannot instantiate the class directly
        static PrinterManager()
        {
            Console.WriteLine("Static constructor");
        }

        // Property to create a singleton instance
        public static PrinterManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new PrinterManager();

                return instance;
            }
        }

        public void Print()
        {
            Console.WriteLine("Instance Print");
        }

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
