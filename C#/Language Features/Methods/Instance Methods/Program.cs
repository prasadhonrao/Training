using System;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1, "Prasad Honrao");
            Console.WriteLine(emp.ToString());
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return string.Format("Id : {0} \t Name : {1}", this.Id, this.Name);
        }
    }
}
