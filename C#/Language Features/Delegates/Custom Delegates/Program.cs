using System;

namespace Training.CSharp
{
    public delegate void WorkPerformedHandler(int hours, WorkType type);

    public class Program
    {
        static void Main(string[] args)
        {
            var del1 = new WorkPerformedHandler(WorkPerformed1);
            var del2 = new WorkPerformedHandler(WorkPerformed2);
        
            del1(1, WorkType.Analysis);
            del2(5, WorkType.Development);

            Console.ReadLine();
        }

        static void WorkPerformed1(int hours, WorkType type)
        {
            Console.WriteLine("Work Type : {0}, Hours Spent : {1}", type, hours);
        }

        static void WorkPerformed2(int hours, WorkType type)
        {
            Console.WriteLine("Work Type : {0}, Hours Spent : {1}", type, hours);
        }
    }
}
