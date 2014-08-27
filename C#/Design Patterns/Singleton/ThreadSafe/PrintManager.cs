using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.ThreadSafe
{
    public sealed class PrinterManager
    {
        private static PrinterManager instance;
        private static readonly object mutex = new object();

        private PrinterManager()
        {
            Console.WriteLine("Instance constructor");
        }

        // Constructor marked as private so client cannot instantiate the class directly
        static PrinterManager()
        {
            Console.WriteLine("Static constructor");
        }

        // Lock statement ensures that only one thread creates an instance if multiple thread tries to access Instance property at the same time
        public static PrinterManager Instance
        {
            get
            {
                lock (mutex)
                {
                    if (instance == null)
                        instance = new PrinterManager();

                    return instance;
                }
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
