using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Concurrent;

namespace ConcurrentStack.Collection.Tests
{
    [TestClass]
    public class ConcurrentStackTests
    {
        [TestMethod]
        public void ConcurrentStack_Push_Test()
        {
            var cs = new ConcurrentStack<string>();
            cs.Push("Red");
            cs.Push("Orange");
            cs.Push("Yellow");
            Assert.IsTrue(cs.Count == 3);
        }

        [TestMethod]
        public void ConcurrentStack_TryPop_Test()
        {
            var cs = new ConcurrentStack<string>();
            cs.Push("Red");
            cs.Push("Orange");
            cs.Push("Yellow");

            string firstItem;
            var success = cs.TryPop(out firstItem);

            Assert.IsTrue(cs.Count == 2);
            Assert.IsTrue(success);
            Assert.IsTrue(firstItem == "Yellow");
        }

        [TestMethod]
        public void ConcurrentStack_TryPeek_Test()
        {
            var cs = new ConcurrentStack<string>();
            cs.Push("Red");
            cs.Push("Orange");
            cs.Push("Yellow");

            string firstItem;
            var success = cs.TryPeek(out firstItem);

            Assert.IsTrue(cs.Count == 3);
            Assert.IsTrue(success);
            Assert.IsTrue(firstItem == "Yellow");
        }

        [TestMethod]
        public void ConcurrentStack_Clear_Test()
        {
            var cs = new ConcurrentStack<string>();
            cs.Push("Red");
            cs.Push("Orange");
            cs.Push("Yellow");

            cs.Clear();
            
            Assert.IsTrue(cs.Count == 0);
            Assert.IsTrue(cs.IsEmpty);
        }
    }
}
