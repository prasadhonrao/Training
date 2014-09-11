using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference.Type.Constraints
{
    [TestClass]
    public class Program
    {
        [TestMethod]
        public void ReferenceConstrainedType_Class_Test()
        {
            var strings = new ReferenceConstrainedType<string>();
            Assert.IsNotNull(strings);
        }

        [TestMethod]
        public void ReferenceConstrainedType_Interface_Test()
        {
            var type = new ReferenceConstrainedType<ISaveable>();
            Assert.IsNotNull(type);
        }

        [TestMethod]
        public void ReferenceConstrainedType_Array_Test()
        {
            var array = new ReferenceConstrainedType<int[]>();
            Assert.IsNotNull(array);
        }

        [TestMethod]
        public void ReferenceConstrainedType_CustomClass_Test()
        {
            var emp = new ReferenceConstrainedType<Employee>();
            Assert.IsNotNull(emp);
        }

        [TestMethod]
        public void ReferenceConstrainedType_Delegate_Test()
        {
            var del = new ReferenceConstrainedType<EventHandler>();
            Assert.IsNotNull(del);
        }

        [TestMethod]
        public void ReferenceConstrainedCollectionType_Class_Test()
        {
            var strings = new ReferenceConstrainedCollection<string>();
            strings.Add("Hello");
            strings.Add("World");
            Assert.IsNotNull(strings);
        }

        [TestMethod]
        public void ReferenceConstrainedCollectionType_Interface_Test()
        {
            var type = new ReferenceConstrainedCollection<ISaveable>();
            Assert.IsNotNull(type);
        }

        [TestMethod]
        public void ReferenceConstrainedCollectionType_Array_Test()
        {
            var intArray = new ReferenceConstrainedCollection<int[]>();
            intArray.Add(new[] { 1, 2, 3 });
            intArray.Add(new[] { 10, 20, 30, 40, 50 });
            Assert.IsNotNull(intArray);
        }

        [TestMethod]
        public void ReferenceConstrainedCollectionType_CustomClass_Test()
        {
            var employess = new ReferenceConstrainedCollection<Employee>();
            employess.Add(new Employee { Id = 1, Name = "Prasad" });
            employess.Add(new Employee { Id = 2, Name = "Scott" });
            Assert.IsNotNull(employess);
        }

        [TestMethod]
        public void ReferenceConstrainedCollectionType_Delegate_Test()
        {
            var delegates = new ReferenceConstrainedCollection<EventHandler>();
            var e1 = new EventHandler(Say);
            var e2 = new EventHandler(Say);
            delegates.Add(e1);
            delegates.Add(e2);
            Assert.IsNotNull(delegates);
        }

        [TestMethod]
        public void ReferenceConstrainedCollectionType_Object_Test()
        {
            var objects = new ReferenceConstrainedCollection<Object>();
            objects.Add(1);
            objects.Add("Hello");
            objects.Add(new[] { 1, 2, 3, 4, 5 });
            objects.Add(new[] { "Hello", "World" });
            Assert.IsNotNull(objects);
        }

        static void Say(object sender, EventArgs message)
        {
            Console.WriteLine(message);
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
