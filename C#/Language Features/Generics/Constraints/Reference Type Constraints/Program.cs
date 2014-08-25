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
            // String 
            var strings = new ReferenceCollection<string>();
            strings.Add("String");

            // Array
            var intArray = new ReferenceCollection<int[]>();
            intArray.Add(new[] { 1, 2, 3 });
            intArray.Add(new[] { 10, 20, 30 });

            // Employee Class
            var employess = new ReferenceCollection<Employee>();
            employess.Add(new Employee { Id = 1, Name = "Prasad" });
            employess.Add(new Employee { Id = 2, Name = "Scott" });

            // Interface
            var savebles = new ReferenceCollection<ISaveable>();
            savebles.Add(new Customer());
            savebles.Add(new Book());


            // Delegate
            var delegates = new ReferenceCollection<EventHandler>();
            var e1 = new EventHandler(Say);
            var e2 = new EventHandler(Say);
            delegates.Add(e1);
            delegates.Add(e2);

            // Object
            var objects = new ReferenceCollection<Object>();
            objects.Add(1);
            objects.Add("Hello");
            objects.Add(intArray);
            objects.Add(strings);

            // Below initialization would fail as Type argument is not a reference type
            //var ints = new ReferenceCollection<int>();
            //var dateTimes = new ReferenceCollection<DateTime>();
            //var guids = new ReferenceCollection<Guid>
        }

        static void Say(object sender, EventArgs message)
        {
            Console.WriteLine(message);
        }
    }

    // When Type constraints is class, the type argument can be any class, interface, array, delegate 
    public class ReferenceCollection<T> where T : class
    {
        List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Customer : ISaveable
    {
        public void Save()
        {
            Console.WriteLine("Customer saved");
        }
    }

    public class Book : ISaveable
    {
        public void Save()
        {
            Console.WriteLine("Book saved");
        }
    }

    public interface ISaveable
    {
        void Save();
    }
}
