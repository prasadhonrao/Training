using System;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var tester = new Worker();

            tester.WorkPerformed += (sender, arg) =>
                                    {
                                        Console.WriteLine("Work Type : {0}, Hour : {1}", arg.WorkType, arg.Hours);
                                    };

            tester.DoWork(8, WorkType.Testing);

            Console.ReadLine();

        }

    }
}
