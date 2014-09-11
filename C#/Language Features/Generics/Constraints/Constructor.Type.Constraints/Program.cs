using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.Type.Constraints
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp1 = new People<Employee>();
            var emp2 = new People<Employee>();

            // Below call would fail as Customer class doesn't contain default parameterless constructor
            // var cust1 = new People<Customer>();

            // By default all the value type contains default parameterless constructor
            var int1 = new People<int>();
            var int2 = new People<int>();

            // Below initialization would fail due to class constraint
            // var int3 = new PeopleRefernceOnly<int>();

            // Practical use case - creating instance using factory like method CreateInstance
            var type = new PeopleReferenceOnly<Employee>();
            var instance = type.CreateInstance();

            Console.ReadLine();
        }
    }

    public class People<T> where T: new() {}

    public class PeopleReferenceOnly<T> where T : class, new() 
    {
        public T CreateInstance()
        {
            return new T();
        }
    }

    public class Employee 
    {
        public Employee()
        {
            Console.WriteLine("Employee instance created");
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public Customer(string name)
        {
            this.Name = name;
        }
    }
}
