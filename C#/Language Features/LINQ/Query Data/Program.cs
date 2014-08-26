using System;
using System.Collections.Generic;
using System.Linq;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> companies = new[] { "Cognizant", "Accenture", "Infosys", "Wipro", "TCS", "HP", "Satyam" };

            List<Employee> employees = new List<Employee>() 
            { 
                new Employee { Id = 1, Name = "Prasad", BirthDate = new DateTime(1980,1,1) },
                new Employee { Id = 2, Name = "Amit", BirthDate = new DateTime(1975,11,22) },
                new Employee { Id = 3, Name = "Scott", BirthDate = new DateTime(1970,06,15) },
                new Employee { Id = 4, Name = "Rita", BirthDate = new DateTime(1982,12,25) },
                new Employee { Id = 5, Name = "Alison", BirthDate = new DateTime(1982,12,25) }
            };

            #region 1. Iterating string collection without LINQ

            Console.WriteLine("1. Iterating string collection");

            foreach (var item in companies)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            #endregion

            #region 2. String Utilities Method

            Console.WriteLine("2. Iterating string collection using utilities class");

            foreach (var item in companies)
            {
                Console.WriteLine(StringUtility.DancingLetters(item));
            }

            Console.WriteLine();

            #endregion

            #region 3. String Extension Method

            Console.WriteLine("3. Iterating string collection using extension method");

            foreach (var item in companies)
            {
                Console.WriteLine(item.AlternateCap());
            }

            Console.WriteLine();

            #endregion

            #region 4. IEnumerable extension method

            Console.WriteLine("4. Iterating string collection using IEnumerable extension method");

            foreach (var item in companies.FormatStringWithAlternateCap())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            #endregion

            #region 5. LINQ Lambda Expression

            Console.WriteLine("5. Iterating using lambda expression");

            var goodCompanies = companies.Where(c => c.StartsWith("C"));

            foreach (var item in goodCompanies)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            #endregion

            #region 6. LINQ Query

            Console.WriteLine("6. Iterating using LINQ Query");

            var badCompanies = from c in companies
                               where c.StartsWith("C")
                               select c;

            foreach (var item in badCompanies)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            #endregion

            #region 7. LINQ Expression over Employess collection

            Console.WriteLine("7. LINQ Expression over Employess collection");

            var empExpression = employees.Where(e => e.BirthDate.Year >= 1975)
                                         .OrderBy(e => e.BirthDate)
                                         .ThenBy(e => e.Name);

            foreach (var employee in empExpression)
            {
                Console.WriteLine("Employee Name {0}, Birth Year {1}", employee.Name, employee.BirthDate.Year);
            }

            Console.WriteLine();
            #endregion

            #region 8. LINQ Query over Employess collection

            Console.WriteLine("8. LINQ Query over Employess collection");

            var empQuery = from e in employees
                           where e.BirthDate.Year >= 1975
                           orderby e.BirthDate, e.Name
                           select new
                           {
                               Name = e.Name,
                               Year = e.BirthDate.Year
                           };

            foreach (var employee in empQuery)
            {
                Console.WriteLine("Employee Name {0}, Birth Year {1}", employee.Name, employee.Year);
            }

            Console.WriteLine();
            #endregion
        }
    }
}
