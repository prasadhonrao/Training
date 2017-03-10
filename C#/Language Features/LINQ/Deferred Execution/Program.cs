using System;
using System.Collections.Generic;
using System.Linq;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new EmployeeRepository();

            var query1 = from e in repo.GetEmployees()
                         where e.Name.StartsWith("R")
                         select e;

            PrintEmployeeList(query1);
            repo.AddEmployee(new Employee(7, "Robert"));
            PrintEmployeeList(query1);

            Console.WriteLine("Using ToList() greedy operator");
            var query2 = (from e in repo.GetEmployees()
                          where e.Name.StartsWith("P")
                          select e).ToList(); // ToList() executes the query 
            PrintEmployeeList(query2);
            repo.AddEmployee(new Employee(8, "Prajakta"));
            PrintEmployeeList(query2);

            Console.ReadLine();
        }

        static void PrintEmployeeList(IEnumerable<Employee> list)
        {
            foreach (var e in list)
            {
                Console.WriteLine(e.Name);
            }

            Console.WriteLine();
        }
    }
}
