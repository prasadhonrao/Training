using System;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { Id = 1, Name = "Prasad Honrao" };
            Console.WriteLine(emp.ToString());
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("Id : {0} \t Name : {1}", this.Id, this.Name);
        }
    }
}
