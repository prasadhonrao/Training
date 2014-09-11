using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace List.Collection.Tests
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void List_Add_Item_Test()
        {
            var numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            Assert.AreEqual(3, numbers.Count);
        }

        [TestMethod]
        public void List_Can_Insert_Item_Test()
        {
            var numbers = new List<int> { 1, 2, 3 };
            numbers.Insert(1, 10);
            Assert.AreEqual(numbers[1], 10);
        }

        [TestMethod]
        public void List_Get_Item_Test()
        {
            var numbers = new List<int> { 1, 2, 3 };

            int firstNumber = numbers[0];
            Assert.IsTrue(firstNumber == 1);
            Assert.AreEqual(3, numbers.Count);
        }

        [TestMethod]
        public void List_Remove_Item_Test()
        {
            var numbers = new List<int> { 1, 2, 3 };
            numbers.RemoveAt(0);
            Assert.AreEqual(2, numbers.Count);
        }

        [TestMethod]
        public void List_Clear_List_Test()
        {
            var numbers = new List<int> { 1, 2, 3 };
            numbers.Clear();
            Assert.AreEqual(0, numbers.Count);
        }

        [TestMethod]
        public void List_Clear_Specific_Items_From_List_Test()
        {
            var numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i);
            }

            numbers.RemoveAll(num => num % 2 == 0);
            Debug.Print(numbers.Count.ToString());
            Assert.IsTrue(numbers.Count == 5);
        }

        [TestMethod]
        public void List_Add_CustomObject_Test()
        {
            var employees = new List<Employee>
            {
                new Employee { Name = "Prasad", DepartmentId = 1 },
                new Employee { Name = "Amit", DepartmentId = 2 },
                new Employee { Name = "Colin", DepartmentId = 3 }
            };

            Assert.AreEqual(3, employees.Count);
            Assert.AreSame("Prasad", employees[0].Name);
        }
    }
}
