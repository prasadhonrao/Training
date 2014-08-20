using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Type empType = typeof(Employee);

            PropertyInfo[] properties = empType.GetProperties();

            foreach (var property in properties)
            {
                Console.WriteLine("Getting attribute for {0}", property.Name);
                var attributes = property.GetCustomAttributes();
                foreach (var item in attributes)
                {
                    Console.WriteLine(item.GetType().Name);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }

    public class Employee
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(20, 60)]
        [Required]
        public int Age { get; set; }
    }
}
