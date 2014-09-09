using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System.Threading;

namespace Cultures
{
    [TestClass]
    public class CultureTests
    {
        [TestMethod]
        public void Turkish_Culture_Fail_Test()
        {
            CultureInfo turkish = CultureInfo.CreateSpecificCulture("tr");
            Thread.CurrentThread.CurrentCulture = turkish;
            var input = "mail";
            var expected = "MAIL";
            Assert.AreNotEqual(expected, input.ToUpper()); // Note AreNotEqual
        }

        [TestMethod]
        public void Turkish_Culture_Pass_Test()
        {
            CultureInfo turkish = CultureInfo.CreateSpecificCulture("tr");
            Thread.CurrentThread.CurrentCulture = turkish;
            var input = "mail";
            var expected = "MAIL";
            Assert.AreEqual(expected, input.ToUpperInvariant()); // Note AreEqual. ToUpperInvariant ignores the culture
        }
    }
}
