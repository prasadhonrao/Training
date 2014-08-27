using Singleton.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Classic
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
            
            Console.WriteLine(string.Format("Instance 1 and Instance 2 are Same? : {0}", instance1 == instance2));

            instance1.Print();
            instance2.Print();

            Console.ReadLine();
        }
    }
}
