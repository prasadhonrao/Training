using System;

namespace Training.CSharp
{
    public class Employee
    {
        static Employee()
        {
            Console.WriteLine("Static constructor was called!");
        }

        public Employee()
        {
            Console.WriteLine("Instance constructor was called!");
        }
    }
}
