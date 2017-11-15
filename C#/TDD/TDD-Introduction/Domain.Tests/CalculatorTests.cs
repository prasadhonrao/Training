using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Domain.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator calc;

        [TestInitialize]
        public void TestInitialize()
        {
            calc = new Calculator();
        }

        [TestMethod()]
        public void Add_Two_Ints_Return_Int_Result_Test()
        {
            var result = calc.Add(10, 20);
            Assert.IsTrue(result == 30);
        }

        [TestMethod()]
        public void Add_One_Positive_One_Negative_Int_Test()
        {
            var result = calc.Add(100, -50);
            Assert.IsTrue(result == 50);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Add_Two_Max_Ints_Throws_Exception_Test()
        {
            var result = calc.Add(int.MaxValue, int.MaxValue);
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void Add_One_Max_Int_One_Negative_Int_Test()
        {
            var result = calc.Add(int.MaxValue, -10);
            Assert.IsTrue(result == 2147483637);
        }
    }
}
