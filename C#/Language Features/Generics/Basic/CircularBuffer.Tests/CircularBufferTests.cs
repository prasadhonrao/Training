using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircularBuffer.Tests
{
    [TestClass]
    public class CircularBufferTests
    {
        [TestMethod]
        public void CircularBuffer_IsFullTest()
        {
            var buffer = new CircularBuffer<double>(3);
            buffer.Add(1.2);
            buffer.Add(2.9);
            buffer.Add(10.76);
            Assert.IsTrue(buffer.IsFull);

            var stringBuffer = new CircularBuffer<string>(10);
            stringBuffer.Add("One");
            stringBuffer.Add("Two");
            stringBuffer.Add("Three");
            Assert.IsFalse(stringBuffer.IsFull);
        }

        [TestMethod]
        public void CircularBuffer_AddTest()
        {
            var buffer = new CircularBuffer<double>(3);
            buffer.Add(1.2);
            buffer.Add(2.9);
            buffer.Add(3.9);
            Assert.IsTrue(buffer.Read() == 1.2);
        }

        [TestMethod]
        public void CircularBuffer_ReadTest()
        {
            var buffer = new CircularBuffer<int>(3);
            buffer.Add(1);
            buffer.Add(2);
            buffer.Add(3);
            Assert.IsTrue(buffer.Read() == 1);
            Assert.IsTrue(buffer.Read() == 2);
            Assert.IsTrue(buffer.Read() == 3);
        }

        [TestMethod]
        public void CircularBuffer_OverrideTest()
        {
            var buffer = new CircularBuffer<int>(3);
            buffer.Add(1);
            buffer.Add(2);
            buffer.Add(3);
            buffer.Add(4);
            Assert.IsTrue(buffer.IsFull);
            Assert.IsTrue(buffer.Read() == 2);
        }
    }
}
