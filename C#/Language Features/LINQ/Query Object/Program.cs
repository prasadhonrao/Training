using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. LINQ Expression 
            Console.WriteLine("LINQ Expression over Object");

            var processExpression = Process.GetProcesses()
                                   .Where(p => p.Threads.Count > 5)
                                   .OrderBy(p => p.ProcessName)
                                   .Select(p => p.ProcessName);

            int counterExpression = 1;

            foreach (var process in processExpression)
            {
                Console.WriteLine("{0}: {1}", counterExpression, process);
                counterExpression += 1;
            }

            Console.WriteLine();

            #endregion

            #region 2. LINQ Query 
            Console.WriteLine("LINQ Query over Object");

            var processQuery = from p in Process.GetProcesses()
                               where p.Threads.Count > 5
                               orderby p.ProcessName
                               select new { Name = p.ProcessName };

            int counterQuery = 1;

            foreach (var process in processQuery)
            {
                Console.WriteLine("{0}: {1}", counterQuery, process.Name);
                counterQuery += 1;
            }

            Console.WriteLine();

            #endregion

            Console.ReadLine();
        }
    }
}
