using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SortedList.Collection.Tests
{
    [TestClass]
    public class SortedListTests
    {
        [TestMethod]
        public void SortedList_Add_Item_Test()
        {
            var numbers = new SortedList<int, string>();
            numbers.Add(1, "One");
            numbers.Add(2, "Two");
            numbers.Add(3, "Three");

            Assert.AreEqual(3, numbers.Count);
        }

        [TestMethod]
        public void SortedList_Get_Item_Test()
        {
            var numbers = new SortedList<int, string>();
            numbers.Add(3, "Three");
            numbers.Add(1, "One");
            numbers.Add(2, "Two");

            KeyValuePair<int, string> firstNumber = numbers.First();
            Assert.IsTrue(firstNumber.Key.Equals(1));
            Assert.AreEqual(3, numbers.Count);
        }

        [TestMethod]
        public void SortedList_Remove_Item_Test()
        {
            var numbers = new SortedList<int, string>();
            numbers.Add(3, "Three");
            numbers.Add(1, "One");
            numbers.Add(2, "Two");

            numbers.Remove(1);
            Assert.AreEqual(2, numbers.Count);
        }

        [TestMethod]
        public void SortedList_Clear_List_Test()
        {
            var numbers = new SortedList<int, string>();
            numbers.Add(3, "Three");
            numbers.Add(1, "One");
            numbers.Add(2, "Two");

            numbers.Clear();
            Assert.AreEqual(0, numbers.Count);
        }

        [TestMethod]
        public void SortedList_Add_CustomObject_Test()
        {
            var employees = new SortedList<int, Employee>();
            employees.Add(1, new Employee { Name = "Prasad", DepartmentId = 1 });
            employees.Add(2, new Employee { Name = "Amit", DepartmentId = 2 });
            employees.Add(3, new Employee { Name = "Colin", DepartmentId = 3 });

            Assert.AreEqual(3, employees.Count);
            Assert.AreEqual("Prasad", employees.First().Value.Name);
        }
    }
}
