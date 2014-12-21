using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class SimpleCalculatorTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void Add_Two_Integer_Returns_Integer()
        {
            // Arrange
            var calculator = new SimpleCalculator();

            // Act
            var result = calculator.Add(10, 20);

            // Assert
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Tests.xml", "add", 
                    DataAccessMethod.Sequential)]
        public void Run_Data_Driven_Test()
        {
            // Arrange
            var calculator = new SimpleCalculator();
            var firstNumber = int.Parse(this.TestContext.DataRow["firstNumber"].ToString());
            var secondNumber = int.Parse(this.TestContext.DataRow["secondNumber"].ToString());
            var expected = int.Parse(this.TestContext.DataRow["expected"].ToString());

            // Act
            var result = calculator.Add(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
