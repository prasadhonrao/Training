using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReadOnlyList.Tests
{
    [TestClass]
    public class ReadOnlyListTests
    {
        [TestMethod]
        public void ReadOnlyList_Intialization()
        {
            List<string> list = new List<string> { "Red", "Green", "Blue" };
            IReadOnlyList<string> readonlylist = new ReadOnlyCollection<string>(list);
            Assert.IsTrue(list.Count == 3);
            Assert.IsTrue(readonlylist.Count == 3);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void ReadOnlyList_Modification_Throws_Exception()
        {
            List<string> list = new List<string> { "Red", "Green", "Blue" };
            var readonlyList = list.AsReadOnly();
            ExternalCode(readonlyList);
        }
        private void ExternalCode(IList<string> readonlyList)
        {
            try
            {
                readonlyList.RemoveAt(2);
            }
            catch (NotSupportedException)
            {
                throw;
            }
        }
    }
}
