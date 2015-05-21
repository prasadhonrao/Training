using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Concurrent;

namespace ConcurrentQueue.Collection.Tests
{
    [TestClass]
    public class ConcurrentQueueTests
    {
        [TestMethod]
        public void ConcurrentQueue_Enqueue_Test()
        {
            var cq = new ConcurrentQueue<string>();
            cq.Enqueue("Red");
            cq.Enqueue("Orange");
            cq.Enqueue("Yellow");
            Assert.IsTrue(cq.Count == 3);
        }

        [TestMethod]
        public void ConcurrentQueue_TryDequeue_Test()
        {
            var cq = new ConcurrentQueue<string>();
            cq.Enqueue("Red");
            cq.Enqueue("Orange");
            cq.Enqueue("Yellow");

            string firstItem;
            var success = cq.TryDequeue(out firstItem);

            Assert.IsTrue(cq.Count == 2);
            Assert.IsTrue(success);
            Assert.IsTrue(firstItem == "Red");
        }

        [TestMethod]
        public void ConcurrentQueue_TryPeek_Test()
        {
            var cq = new ConcurrentQueue<string>();
            cq.Enqueue("Red");
            cq.Enqueue("Orange");
            cq.Enqueue("Yellow");

            string firstItem;
            var success = cq.TryPeek(out firstItem);

            Assert.IsTrue(cq.Count == 3);
            Assert.IsTrue(success);
            Assert.IsTrue(firstItem == "Red");
        }
    }
}
