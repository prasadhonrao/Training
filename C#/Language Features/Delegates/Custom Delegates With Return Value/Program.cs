using System;

namespace Training.CSharp
{
    public delegate int WorkPerformedHandler (int hours, WorkType workType);
    
    class Program
    {
        static void Main(string[] args)
        {
            // Single delegate
            var del1 = new WorkPerformedHandler(WorkPerformed1);
            int hour = del1(10, WorkType.Support);
            Console.WriteLine("Hour {0}", hour);

            // Multicast delegate
            var del2 = new WorkPerformedHandler(WorkPerformed2);
            var del3 = new WorkPerformedHandler(WorkPerformed3);
            var del4 = new WorkPerformedHandler(WorkPerformed4);

            del2 += del3 + del4;
            int hours = del2(10, WorkType.Support); // Will return value only of last delegate in invocation list
            Console.WriteLine("Hours {0}", hours);

            Console.ReadLine();
        }

        static int WorkPerformed1(int hours, WorkType type)
        {
            Console.WriteLine("Work Type : {0}, Hours Spent : {1}", type, hours);
            return hours + 1;
        }

        static int WorkPerformed2(int hours, WorkType type)
        {
            Console.WriteLine("Work Type : {0}, Hours Spent : {1}", type, hours);
            return hours + 2;
        }

        static int WorkPerformed3(int hours, WorkType type)
        {
            Console.WriteLine("Work Type : {0}, Hours Spent : {1}", type, hours);
            return hours + 3;
        }

        static int WorkPerformed4(int hours, WorkType type)
        {
            Console.WriteLine("Work Type : {0}, Hours Spent : {1}", type, hours);
            return hours + 4;
        }
    }
}
