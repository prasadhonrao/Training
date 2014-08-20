using System;

namespace Training.CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new PermanentEmployee();
            int salary = emp.CalculateSalary(5);
            Console.WriteLine("Permanent employee weekly salary {0}", salary);

            emp = new TemporaryEmployee();
            salary = emp.CalculateSalary(5);
            Console.WriteLine("Temporary employee weekly salary {0}", salary);

            emp = new ContactorEmployee();
            salary = emp.CalculateSalary(5);
            Console.WriteLine("Contractor employee weekly salary {0}", salary);

            Console.ReadLine();
        }
    }
}
