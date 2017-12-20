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

        [TestMethod]
        public void WordCount_Test()
        {
            var result = "My name is Prasad Honrao".CountWords();
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void WordCount_Blank_String_Test()
        {
            var result = "".CountWords();
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void WordCount_Long_Blank_String_Test()
        {
            var result = "        ".CountWords();
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CountUniqueWords_Test()
        {
            var result = "Twinkle Twinkle Litte Star".CountUniqueWords();
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void CountCharactersWithoutSpace_Test()
        {
            var result = "Twinkle Twinkle Litte Star".CountCharactersWithoutSpace();
            Assert.AreEqual(23, result);
        }
    }
}
