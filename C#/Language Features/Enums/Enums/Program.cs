using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var color = RainbowColor.Red;
            Console.WriteLine(color);

            var emp = new Employee();
            emp.Type = EmployeeType.Permanent;
            Console.WriteLine("Employee is of {0} type", emp.Type);

            Console.ReadLine();
        }
    }

    public enum RainbowColor
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Indigo,
        Violet
    }

    public enum EmployeeType
    {
        Temporary = 1,
        Contractor = 34,
        Permanent = 100
    }
}
