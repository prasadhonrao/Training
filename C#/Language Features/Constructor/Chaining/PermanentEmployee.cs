
using System;
namespace Training.CSharp
{
    class PermanentEmployee : Employee
    {
        public PermanentEmployee(string name)
            : base(name)
        {
            Console.WriteLine("New permanent employee {0} created.", name);
        }
    }
}
