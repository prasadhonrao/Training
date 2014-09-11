using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SortedDictionary.Collection.Tests
{
    [TestClass]
    public class SortedDictionaryTests
    {
        [TestMethod]
        public void SortedDictionary_Add_Item_Test()
        {
            var numbers = new SortedDictionary<int, string>();
            numbers.Add(1, "One");
            numbers.Add(3, "Three");
            numbers.Add(2, "Two");

            Assert.AreEqual(3, numbers.Count);
        }

        [TestMethod]
        public void SortedDictionary_Get_Item_Test()
        {
            var numbers = new SortedDictionary<int, string>();
            numbers.Add(3, "Three");
            numbers.Add(1, "One");
            numbers.Add(2, "Two");

            string value = numbers.First().Value;
            Assert.IsTrue(value.Equals("One"));
            Assert.AreEqual(3, numbers.Count);
        }

        [TestMethod]
        public void SortedDictionary_Remove_Item_Test()
        {
            var numbers = new SortedDictionary<int, string>();
            numbers.Add(3, "Three");
            numbers.Add(1, "One");
            numbers.Add(2, "Two");

            numbers.Remove(numbers.First().Key);
            Assert.AreEqual(2, numbers.Count);
            Assert.IsFalse(numbers.ContainsKey(1));
        }

        [TestMethod]
        public void SortedDictionary_Clear_List_Test()
        {
            var numbers = new SortedDictionary<int, string>();
            numbers.Add(3, "Three");
            numbers.Add(1, "One");
            numbers.Add(2, "Two");

            numbers.Clear();
            Assert.AreEqual(0, numbers.Count);
        }


        [TestMethod]
        public void SortedDictionary_Add_CustomObject_Test()
        {
            var employees = new SortedDictionary<int, Employee>();
            employees.Add(3, new Employee { Name = "Colin", DepartmentId = 3 });
            employees.Add(1, new Employee { Name = "Prasad", DepartmentId = 1 });
            employees.Add(2, new Employee { Name = "Amit", DepartmentId = 2 });

            Assert.AreEqual(3, employees.Count);
            Assert.AreSame("Prasad", employees.First().Value.Name);
        }
    }
}
