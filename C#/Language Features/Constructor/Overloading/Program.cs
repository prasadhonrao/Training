using System;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Console.WriteLine("Employee 1 name length is {0}", e1.Name.Length);

            Employee e2 = new Employee("Prasad Honrao");
            Console.WriteLine("Employee 2 name length is {0}", e2.Name.Length);

            Console.ReadLine();
        }
    }
}
