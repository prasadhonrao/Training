using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace HashSet.Collection.Tests
{
    [TestClass]
    public class HashSetTests
    {
        [TestMethod]
        public void HashSet_Add_Item_Test()
        {
            var numbers = new HashSet<int> { 1, 2, 3, 3, 4 }; // note only one instance of 3 will be stored in the collection
            Assert.AreEqual(4, numbers.Count);
        }

        [TestMethod]
        public void HashSet_Get_Item_Test()
        {
            var numbers = new HashSet<int> { 1, 2, 3 };

            int firstNumber = numbers.First();
            Assert.IsTrue(firstNumber == 1);
            Assert.AreEqual(3, numbers.Count);
        }

        [TestMethod]
        public void HashSet_Remove_Item_Test()
        {
            var numbers = new HashSet<int> { 1, 2, 3 };
            numbers.Remove(numbers.First());
            Assert.AreEqual(2, numbers.Count);
        }

        [TestMethod]
        public void HashSet_Clear_HashSet_Test()
        {
            var numbers = new HashSet<int> { 1, 2, 3 };
            numbers.Clear();
            Assert.AreEqual(0, numbers.Count);
        }

        [TestMethod]
        public void HashSet_Clear_Specific_Items_From_HashSet_Test()
        {
            var numbers = new HashSet<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i);
            }

            numbers.RemoveWhere(num => num % 2 == 0);
            Assert.IsTrue(numbers.Count == 5);
        }

        [TestMethod]
        public void HashSet_Add_CustomObject_Test()
        {
            var employees = new HashSet<Employee>
            {
                new Employee {Name = "Prasad", DepartmentId = 1},
                new Employee {Name = "Amit", DepartmentId = 2},
                new Employee {Name = "Colin", DepartmentId = 3}
            };

            Assert.AreEqual(3, employees.Count);
            Assert.AreSame("Prasad", employees.First().Name);
        }

        [TestMethod]
        public void HashSet_Add_CustomDuplicateObjectSameInstance_Test()
        {
            var emp = new Employee() { Name = "Prasad" };
            var employees = new HashSet<Employee>();
            employees.Add(emp);
            employees.Add(emp);

            Assert.AreEqual(1, employees.Count);
        }

        [TestMethod]
        public void HashSet_Add_CustomDuplicateObjectDifferentInstances_Test()
        {
            // No way to identify duplicate object
            var emp1 = new Employee() { Name = "Prasad" };
            var emp2 = new Employee() { Name = "Prasad" };

            var employees = new HashSet<Employee>();

            employees.Add(emp1);
            employees.Add(emp2);

            Assert.AreEqual(2, employees.Count);
        }

        [TestMethod]
        public void HashSet_Intersect_Test()
        {
            var set1 = new HashSet<int> { 1, 2, 3 };
            var set2 = new HashSet<int> { 2, 3, 4 };

            set1.IntersectWith(set2);
            Assert.IsTrue(set1.SetEquals(new[] { 2, 3 }));
        }

        [TestMethod]
        public void HashSet_Union_Test()
        {
            var set1 = new HashSet<int> { 1, 2, 3 };
            var set2 = new HashSet<int> { 2, 3, 4 };

            set1.UnionWith(set2);
            Assert.IsTrue(set1.SetEquals(new[] { 1, 2, 3, 4 }));
        }

        [TestMethod]
        public void HashSet_SymmetricExceptWith_Test()
        {
            var set1 = new HashSet<int> { 1, 2, 3 };
            var set2 = new HashSet<int> { 2, 3, 4 };

            set1.SymmetricExceptWith(set2);
            Assert.IsTrue(set1.SetEquals(new[] { 1, 4 }));
        }
    }
}
