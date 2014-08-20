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
            Type empType = typeof(Employee);

            var ageProperty = empType.GetProperty("Age");

            var ageAttributes = ageProperty.GetCustomAttributes(false);

            foreach (var item in ageAttributes)
            {
                Console.WriteLine(item.GetType().Name);
            }

            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int Id { get; set; }

        [Age(20, 60, Message = "Value must be between 20 and 60")]
        public int Age { get; set; }
    }

    class AgeAttribute : Attribute
    {
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public string Message { get; set; }

        public AgeAttribute(int minAge, int maxAge)
        {
            this.MinAge = minAge;
            this.MaxAge = maxAge;
            this.Message = string.Empty;
        }
    }
}
