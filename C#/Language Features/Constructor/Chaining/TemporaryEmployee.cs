using System;

namespace Training.CSharp
{
    class TemporaryEmployee : Employee
    {
        public TemporaryEmployee(string name)
            : base(name)
        {
            Console.WriteLine("New temporary employee {0} created.", name);
        }
    }
}
