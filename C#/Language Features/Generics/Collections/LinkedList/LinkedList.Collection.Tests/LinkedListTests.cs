using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LinkedList.Collection.Tests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void LinkedList_Add_Item_Test()
        {
            var numbers = new LinkedList<int>();
            numbers.AddFirst(1); // 1
            numbers.AddFirst(2); // 2,1 
            numbers.AddFirst(3); // 3,2,1

            Assert.AreEqual(3, numbers.Count);
        }

        [TestMethod]
        public void LinkedList_AddAfter_Item_Test()
        {
            var numbers = new LinkedList<int>();
            numbers.AddFirst(1); // 1
            numbers.AddFirst(2); // 2,1 
            numbers.AddFirst(3); // 3,2,1

            var first = numbers.First;
            numbers.AddAfter(first, 10); // 3, 10, 2, 1

            Assert.AreEqual(4, numbers.Count);
            Assert.AreEqual(10, numbers.First.Next.Value);
        }

        [TestMethod]
        public void LinkedList_AddBefore_Item_Test()
        {
            var numbers = new LinkedList<int>();
            numbers.AddFirst(1); // 1
            numbers.AddFirst(2); // 2,1 
            numbers.AddFirst(3); // 3,2,1

            var first = numbers.First;
            numbers.AddBefore(first, 10); // 10, 3, 2, 1

            Assert.AreEqual(4, numbers.Count);
            Assert.AreEqual(10, numbers.First.Value);
        }

        [TestMethod]
        public void LinkedList_Get_Item_Test()
        {
            var numbers = new LinkedList<int>();
            numbers.AddFirst(1); // 1
            numbers.AddFirst(2); // 2,1 
            numbers.AddFirst(3); // 3,2,1

            int firstNumber = numbers.First.Value;
            Assert.IsTrue(firstNumber == 3);
            Assert.AreEqual(3, numbers.Count);
        }

        [TestMethod]
        public void LinkedList_Remove_Item_Test()
        {
            var numbers = new LinkedList<int>();
            numbers.AddFirst(1); // 1
            numbers.AddFirst(2); // 2,1 
            numbers.AddFirst(3); // 3,2,1

            numbers.RemoveLast(); // 3,2
            Assert.AreEqual(2, numbers.Count);
        }

        [TestMethod]
        public void LinkedList_Clear_List_Test()
        {
            var numbers = new LinkedList<int>();
            numbers.AddFirst(1); // 1
            numbers.AddFirst(2); // 2,1 
            numbers.AddFirst(3); // 3,2,1

            numbers.Clear();
            Assert.AreEqual(0, numbers.Count);
        }


        [TestMethod]
        public void LinkedList_Add_CustomObject_Test()
        {
            var employees = new LinkedList<Employee>();
            employees.AddFirst(new Employee { Name = "Prasad", DepartmentId = 1 });
            employees.AddFirst(new Employee { Name = "Amit", DepartmentId = 2 });
            employees.AddFirst(new Employee { Name = "Colin", DepartmentId = 3 });

            Assert.AreEqual(3, employees.Count);
            Assert.AreSame("Prasad", employees.Last.Value.Name);
        }
    }
}
