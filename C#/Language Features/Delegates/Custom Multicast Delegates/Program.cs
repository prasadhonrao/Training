using System;

namespace Training.CSharp
{
    public delegate void WorkPerformedHandler(int hours, WorkType workType);

    class Program
    {
        static void Main(string[] args)
        {
            var del1 = new WorkPerformedHandler(WorkPerformed1);
            var del2 = new WorkPerformedHandler(WorkPerformed2);
            var del3 = new WorkPerformedHandler(WorkPerformed3);

            // multicast delegate
            del1 += del2 + del3;

            del1(10, WorkType.Testing);

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

        static void WorkPerformed3(int hours, WorkType type)
        {
            Console.WriteLine("Work Type : {0}, Hours Spent : {1}", type, hours);
        }
    }


}
