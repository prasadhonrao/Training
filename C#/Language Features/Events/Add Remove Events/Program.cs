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
            var analyst = new Worker();

            // Even though event was subscribed 2 times, event handler will be executed only once, 
            // since event subscribers are maintained using add / remove event syntax
            analyst.WorkPerformed += analyst_WorkPerformed;
            analyst.WorkPerformed += analyst_WorkPerformed;
            
            analyst.DoWork(8, WorkType.Analysis);

            Console.ReadLine();
        }

        private static void analyst_WorkPerformed(int hours, WorkType type)
        {
            Console.WriteLine("Work Type : {0}, Hour {1}", type, hours);
        }
    }
}
