using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Stack.Collection.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void Stack_Push_Item_Test()
        {
            var numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);

            Assert.AreEqual(3, numbers.Count);
        }

        [TestMethod]
        public void Stack_Peek_Item_Test()
        {
            var numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);

            int firstNumber = numbers.Peek();
            Assert.IsTrue(firstNumber == 3);
            Assert.AreEqual(3, numbers.Count);
        }

        [TestMethod]
        public void Stack_Pop_Item_Test()
        {
            var numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);

            int firstNumber = numbers.Pop();
            Assert.IsTrue(firstNumber == 3);
            Assert.AreEqual(2, numbers.Count);
        }

        [TestMethod]
        public void Stack_Clear_Stack_Test()
        {
            var numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);

            numbers.Clear();
            Assert.AreEqual(0, numbers.Count);
        }

        [TestMethod]
        public void Stack_Add_CustomObject_Test()
        {
            var employees = new Stack<Employee>();
            employees.Push(new Employee { Name = "Prasad", DepartmentId = 1 });
            employees.Push(new Employee { Name = "Amit", DepartmentId = 2 });
            employees.Push(new Employee { Name = "Colin", DepartmentId = 3 });

            Assert.AreEqual(3, employees.Count);
            Assert.AreSame("Colin", employees.Pop().Name);
            Assert.AreEqual(2, employees.Count);
        }

        [TestMethod]
        public void Stack_Convert_To_Array_Test()
        {
            var numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);

            var numbersAsArray = numbers.ToArray();

            numbers.Pop();
            Assert.AreEqual(2, numbers.Count);
            Assert.AreEqual(3, numbersAsArray.Length);
        }
    }
}
