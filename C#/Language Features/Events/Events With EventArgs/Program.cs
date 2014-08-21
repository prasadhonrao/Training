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
            var tester = new Worker();

            tester.WorkPerformed += tester_WorkPerformed;
            tester.WorkCompleted += tester_WorkCompleted;

            tester.DoWork(8, WorkType.Testing);

            Console.ReadLine();
        }

        static void tester_WorkPerformed(object sender, WorkPerformedEventArgs args)
        {
            Console.WriteLine("Work Type : {0}, Hour : {1}", args.WorkType, args.Hour);
        }

        static void tester_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Work completed successfully");
        }

       
    }
}
