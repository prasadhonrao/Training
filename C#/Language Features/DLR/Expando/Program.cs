using System;
using System.Dynamic;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic employee = new ExpandoObject();

            // Adding dynamic property
            employee.Name = "Prasad Honrao";
            Console.WriteLine(employee.Name);

            // Adding dynamic method
            employee.Speak = new Action(() => Console.WriteLine(employee.Name));
            employee.Speak();

            Console.WriteLine("\nIterating over expando object items");
            foreach (var item in employee)
            {
                Console.WriteLine(item.Key);
            }

            Console.ReadLine();
        }
    }
}
