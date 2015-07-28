using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReadOnlyDictionary.Tests
{
    [TestClass]
    public class ReadOnlyDictionaryTests
    {
        [TestMethod]
        public void ReadOnlyDictionary_Initialization_Test()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { EIN = 1, FirstName = "John", LastName  = "Doe", Salary= 55000M },
                new Employee() { EIN = 2, FirstName = "Jane", LastName = "Doe", Salary= 55000M },
                new Employee() { EIN = 3, FirstName = "Don", LastName  = "DeLuth", Salary= 55000M },
            };

            Dictionary<int, Employee> einLookUp = employees.ToDictionary(x => x.EIN);
            IReadOnlyDictionary<int, Employee> readOnlyStaff = einLookUp;
            var eins = readOnlyStaff.Keys;
            var allEmployees = readOnlyStaff.Values;
            foreach (var emp in allEmployees)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName);
            }
        }
    }

    class Employee
    {
        public int EIN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
    }
}
