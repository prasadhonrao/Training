using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Immutable;

namespace ImmutableQueue.Collection.Tests
{
    [TestClass]
    public class ImmutableQueueTests
    {
        [TestMethod]
        public void ImmutableQueue_IsEmpty_Test()
        {
            var iqueue = ImmutableQueue<int>.Empty;
            Assert.IsTrue(iqueue.IsEmpty);
            var newQueue = iqueue.Enqueue(1);
            Assert.IsTrue(iqueue.IsEmpty);
            Assert.IsFalse(newQueue.IsEmpty);
        }

        [TestMethod]
        public void ImmutableQueue_Add_Test()
        {
            var emptyFruitBasket = ImmutableQueue<string>.Empty;
            var fruitBasket = emptyFruitBasket.Enqueue("Banana");
            Assert.IsTrue(emptyFruitBasket.IsEmpty);
            Assert.IsFalse(fruitBasket.IsEmpty);
            Assert.IsTrue(fruitBasket.ToImmutableList().Count > 0);
        }

        [TestMethod]
        public void ImmutableQueue_GetItem_Test()
        {
            var emptyFruitBasket = ImmutableQueue<string>.Empty;
            var fruitBasket = emptyFruitBasket.Enqueue("Banana");
            Assert.IsTrue(emptyFruitBasket.IsEmpty);
            string fruit = string.Empty;
            fruitBasket = fruitBasket.Dequeue(out fruit);
            Assert.IsTrue(string.Equals(fruit, "Banana"));
            Assert.IsTrue(fruitBasket.IsEmpty);
        }

    }
}
