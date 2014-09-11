using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace SortedSet.Collection.Tests
{
    [TestClass]
    public class SortedSetTests
    {
        [TestMethod]
        public void SortedSet_Add_Item_Test()
        {
            var numbers = new SortedSet<int>();
            numbers.Add(10);
            numbers.Add(30);
            numbers.Add(20);
            numbers.Add(5);
            numbers.Add(100);

            Assert.AreEqual(5, numbers.Count);
        }

        [TestMethod]
        public void SortedSet_Get_Item_Test()
        {
            var numbers = new SortedSet<int> { 10, 30, 20, 5, 100 };

            int firstNumber = numbers.First();
            Assert.IsTrue(firstNumber == 5);
            Assert.AreEqual(5, numbers.Count);
        }

        [TestMethod]
        public void SortedSet_Remove_Item_Test()
        {
            var numbers = new SortedSet<int> { 10, 30, 20, 5, 100 };

            numbers.Remove(numbers.First());
            Assert.AreEqual(10, numbers.First());
            Assert.AreEqual(4, numbers.Count);
        }

        [TestMethod]
        public void SortedSet_Clear_HashSet_Test()
        {
            var numbers = new SortedSet<int> { 10, 30, 20, 5, 100 };

            numbers.Clear();
            Assert.AreEqual(0, numbers.Count);
        }

        [TestMethod]
        public void SortedSet_Clear_Specific_Items_From_HashSet_Test()
        {
            var numbers = new SortedSet<int> { 10, 30, 20, 5, 100 };

            numbers.RemoveWhere(num => num % 2 == 0);
            Assert.IsTrue(numbers.Count == 1);
        }

        [TestMethod]
        public void SortedSet_Intersect_Test()
        {
            var first = new[] { 1, 2, 3 };
            var second = new[] { 2, 3, 4 };
            Assert.IsTrue(first.Intersect(second).Count() == 2);
        }

        [TestMethod]
        public void SortedSet_Union_Test()
        {
            var first = new[] { 1, 2, 3 };
            var second = new[] { 2, 3, 4 };
            Assert.IsTrue(first.Union(second).Count() == 4);
        }
    }
}
