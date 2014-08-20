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
            var emp = new Employee() { Age = 20 };

            // Extract property value using reflection
            Type t = emp.GetType();
            var ageProperty = t.GetProperty("Age");
            var ageValue = ageProperty.GetValue(emp, null);
            Console.WriteLine("Employee Age is {0}", ageValue);

            // Call method using reflection
            t = emp.GetType();
            var getName = t.GetMethod("GetName");
            var empName = (string)getName.Invoke(emp, new object[] { 1 });
            Console.WriteLine("Employee Name is {0}", empName);

            // Dynamic
            dynamic d = emp;
            int age = d.Age;
            string name = d.GetName(1);
            Console.WriteLine("Employee Name {0} Age {1}", name, age);

            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int Age { get; set; }

        public string GetName(int empId)
        {
            return "Prasad Honrao";
        }
    }
}
