using Singleton.ThreadSafe;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Singleton.ThreadSafe
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterManager.Print("Static print");
            PrinterManager.Instance.Print();

            // This will still refer to the instance created earlier
            var instance1 = PrinterManager.Instance;
            var instance2 = PrinterManager.Instance;

            // Creating 100 instances pointing to same singleton created earlier
            List<Task<PrinterManager>> tasks = new List<Task<PrinterManager>>();
            
            for (int i = 0; i < 100; i++)
            {
                tasks.Add(Task.Factory.StartNew(() => PrinterManager.Instance));
            }

            Console.WriteLine(string.Format("Instance 1 and Instance 2 are Same? : {0}", instance1 == instance2));
            bool result = tasks.All(t => t.Result.Equals(instance1));
            Console.WriteLine(string.Format("Instance 1 and all other instance created using TPL are same? : {0}", result));

            instance1.Print();
            instance2.Print();
        }
    }
}
