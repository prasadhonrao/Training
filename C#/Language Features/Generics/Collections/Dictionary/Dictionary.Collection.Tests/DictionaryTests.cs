using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Dictionary.Collection.Tests
{
    [TestClass]
    public class DictionaryTests
    {
        [TestMethod]
        public void Dictionary_Add_Item_Test()
        {
            var numbers = new Dictionary<int, string>();
            numbers.Add(1, "One");
            numbers.Add(2, "Two");
            numbers.Add(3, "Three");

            Assert.AreEqual(3, numbers.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Dictionary_Add_DuplicateKey_Test()
        {
            var numbers = new Dictionary<int, string>();
            numbers.Add(1, "One");
            numbers.Add(1, "Two");
            numbers.Add(3, "Three");

            Assert.AreEqual(3, numbers.Count);
        }

        [TestMethod]
        public void Dictionary_AddUpdate_Using_Indexer_Test()
        {
            var stock = new Dictionary<string, int>()
            {
                {"Mufti", 10},
                {"Lewis", 20},
                {"Killer", 5}
            };

            stock["Killer"] = 15;
            stock["Local"] = 100;
            Assert.AreEqual(15, stock["Killer"]);
            Assert.AreEqual(100, stock["Local"]);
        }

        [TestMethod]
        public void Dictionary_Get_Item_Test()
        {
            var numbers = new Dictionary<int, string>();
            numbers.Add(1, "One");
            numbers.Add(2, "Two");
            numbers.Add(3, "Three");

            string itemWithKey1 = numbers[1];
            Assert.IsTrue(itemWithKey1.Equals("One"));
            Assert.AreEqual(3, numbers.Count);
        }

        [TestMethod]
        public void Dictionary_Remove_Item_Test()
        {
            var numbers = new Dictionary<int, string>();
            numbers.Add(1, "One");
            numbers.Add(2, "Two");
            numbers.Add(3, "Three");

            numbers.Remove(1);
            Assert.AreEqual(2, numbers.Count);
            Assert.IsFalse(numbers.ContainsKey(1));
        }

        [TestMethod]
        public void Dictionary_Clear_List_Test()
        {
            var numbers = new Dictionary<int, string>();
            numbers.Add(1, "One");
            numbers.Add(2, "Two");
            numbers.Add(3, "Three");

            numbers.Clear();
            Assert.AreEqual(0, numbers.Count);
        }

        [TestMethod]
        public void Dictionary_Add_CustomObject_Test()
        {
            var employees = new Dictionary<int, Employee>();
            employees.Add(1, new Employee { Name = "Prasad", DepartmentId = 1 });
            employees.Add(2, new Employee { Name = "Amit", DepartmentId = 2 });
            employees.Add(3, new Employee { Name = "Colin", DepartmentId = 3 });

            Assert.AreEqual(3, employees.Count);
            Assert.AreSame("Prasad", employees[1].Name);
        }
    }
}
