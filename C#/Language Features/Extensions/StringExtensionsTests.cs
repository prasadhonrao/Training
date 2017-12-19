using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Extensions.Library;

namespace Extensions
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void ToInt_Valid_Input_Test()
        {
            var input = "100".ToInt();
            Assert.IsTrue(input == 100);
        }

        [TestMethod]
        public void ToInt_Invalid_Input_Test()
        {
            var input = "AAA".ToInt();
            Assert.IsTrue(input == 0);
        }

        [TestMethod]
        public void Occurence_Valid_Occurence_Test()
        {
            var occurenceCount = "supercalifragilisticexpealidocious".Occurrence("li");
            Assert.AreEqual(3, occurenceCount);
        }

        [TestMethod]
        public void Occurence_Invalid_Occurence_Test()
        {
            var occurenceCount = "prasad".Occurrence("xxx");
            Assert.AreEqual(0, occurenceCount);
        }
    }
}
