using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iterating over string array...");

            string[] colors = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Voilet" };
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("\nIterating over generic string list");
            List<string> rainbow = new List<string>() { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Voilet" };
            foreach (var color in rainbow)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("\nIterating over generic object list");
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Name = "Prasad" });
            employees.Add(new Employee() { Name = "Amit" });
            employees.Add(new Employee() { Name = "Colin" });

            foreach (var item in employees)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("\nIterating over processes list");
            Process[] processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                Console.WriteLine(process.ProcessName);
            }

            Console.ReadLine();
        }
    }
}
