using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Queue.Collection.Tests
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void Queue_Enqueue_Item_Test()
        {
            var numbers = new Queue<int>();
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);

            Assert.AreEqual(3, numbers.Count);
        }

        [TestMethod]
        public void Queue_Peek_Item_Test()
        {
            var numbers = new Queue<int>();
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);

            int firstNumber = numbers.Peek();
            Assert.IsTrue(firstNumber == 1);
            Assert.AreEqual(3, numbers.Count);
        }

        [TestMethod]
        public void Queue_Dequeue_Item_Test()
        {
            var numbers = new Queue<int>();
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);

            int firstNumber = numbers.Dequeue();
            Assert.IsTrue(firstNumber == 1);
            Assert.AreEqual(2, numbers.Count);
        }

        [TestMethod]
        public void Queue_Clear_Queue_Test()
        {
            var numbers = new Queue<int>();
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);

            numbers.Clear();
            Assert.AreEqual(0, numbers.Count);
        }

        [TestMethod]
        public void Queue_Add_CustomObject_Test()
        {
            var employees = new Queue<Employee>();
            employees.Enqueue(new Employee { Name = "Prasad", DepartmentId = 1 });
            employees.Enqueue(new Employee { Name = "Amit", DepartmentId = 2 });
            employees.Enqueue(new Employee { Name = "Colin", DepartmentId = 3 });

            Assert.AreEqual(3, employees.Count);
            Assert.AreSame("Prasad", employees.Dequeue().Name);
            Assert.AreEqual(2, employees.Count);
        }

        [TestMethod]
        public void Queue_Convert_To_Array_Test()
        {
            var numbers = new Queue<int>();
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);

            var numbersAsArray = numbers.ToArray();

            numbers.Dequeue();
            Assert.AreEqual(2, numbers.Count);
            Assert.AreEqual(3, numbersAsArray.Length);
        }
    }
}
