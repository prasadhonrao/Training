using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Extensions.Library;

namespace Extensions
{
    [TestClass]
    public class DateExtensionsTests
    {
        [TestMethod]
        public void Date_1st_OrdinalSuffix_Test()
        {
            var input = new DateTime(2000, 01, 01).OrdinalSuffix();
            Assert.IsTrue(input == "1st");
        }

        [TestMethod]
        public void Date_2nd_OrdinalSuffix_Test()
        {
            var input = new DateTime(2000, 01, 02).OrdinalSuffix();
            Assert.IsTrue(input == "2nd");
        }

        [TestMethod]
        public void Date_3rd_OrdinalSuffix_Test()
        {
            var input = new DateTime(2000, 01, 03).OrdinalSuffix();
            Assert.IsTrue(input == "3rd");
        }

        [TestMethod]
        public void Date_4th_OrdinalSuffix_Test()
        {
            var input = new DateTime(2000, 01, 04).OrdinalSuffix();
            Assert.IsTrue(input == "4th");
        }
    }
}
