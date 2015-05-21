using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Concurrent;

namespace ConcurrentBag.Collection.Tests
{
    // Unlike Stack or Queue, Order of retrieving item from ConcurrentBag 
    // is not fixed in multithreaded environment.

    [TestClass]
    public class ConcurrentBagTests
    {
        [TestMethod]
        public void ConcurrentBag_Add_Test()
        {
            var cb = new ConcurrentBag<string>();
            cb.Add("Red");
            cb.Add("Orange");
            cb.Add("Yellow");
            Assert.IsTrue(cb.Count == 3);
        }

        [TestMethod]
        public void ConcurrentBag_TryTake_Test()
        {
            var cb = new ConcurrentBag<string>();
            cb.Add("Red");
            cb.Add("Orange");
            cb.Add("Yellow");

            string result;
            var success = cb.TryTake(out result);

            Assert.IsTrue(cb.Count == 2);
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void ConcurrentBag_TryPeek_Test()
        {
            var cb = new ConcurrentBag<string>();
            cb.Add("Red");
            cb.Add("Orange");
            cb.Add("Yellow");

            string result;
            var success = cb.TryPeek(out result);

            Assert.IsTrue(cb.Count == 3);
            Assert.IsTrue(success);
        }
    }
}
