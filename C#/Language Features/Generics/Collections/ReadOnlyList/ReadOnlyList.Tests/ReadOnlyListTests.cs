using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReadOnlyList.Tests
{
    [TestClass]
    public class ReadOnlyListTests
    {
        [TestMethod]
        public void IReadOnlyList_Intialization()
        {
            IReadOnlyList<string> list = new[] { "Red", "Green", "Blue" };
            Assert.IsTrue(list.Count == 3);
        }
    }
}
