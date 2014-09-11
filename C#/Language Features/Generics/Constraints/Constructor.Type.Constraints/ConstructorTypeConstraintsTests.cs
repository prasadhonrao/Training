using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// There’s no way of constraining type parameters to force other constructor signatures.

namespace Constructor.Type.Constraints
{
    [TestClass]
    public class ConstructorTypeConstraintsTests
    {
        public class People<T> where T : new() { }

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

        public class CustomerWithDefaultConstructor
        {
            public string Name { get; set; }
            public CustomerWithDefaultConstructor(string name)
            {
                this.Name = name;
            }

            public CustomerWithDefaultConstructor()
            {

            }
        }

        public class Factory
        {
            public T CreateInstance<T>() where T : new()
            {
                return new T();
            }
        }

        [TestMethod]
        public void ConstructorType_Test()
        {
            var emp1 = new People<Employee>();
            Assert.IsNotNull(emp1);

            // Below call would fail as Customer class doesn't contain default parameterless constructor
            // var cust1 = new People<Customer>();

            var cust = new People<CustomerWithDefaultConstructor>();
            Assert.IsNotNull(cust);
        }

        [TestMethod]
        public void ConstructorType_Factory_Test()
        {
            var factory = new Factory();
            var emp = factory.CreateInstance<Employee>();
            Assert.IsNotNull(emp);
        }
    }
}