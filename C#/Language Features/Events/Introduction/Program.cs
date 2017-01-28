using System;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var analyst = new Worker();
            analyst.WorkPerformed += analyst_WorkPerformed;
            analyst.DoWork(2, WorkType.Analysis);

            Console.ReadLine();
        }

        static void analyst_WorkPerformed(int hours, WorkType workType)
        {
            Console.WriteLine("Work Type : {0}, Hour {1}", workType, hours);
        }
    }
}
