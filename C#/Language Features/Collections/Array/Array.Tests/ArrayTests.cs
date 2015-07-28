using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Array.Tests
{
    [TestClass]
    public class ArrayTests
    {
        [TestMethod]
        public void Array_Initilization_Test()
        {
            string[] daysOfWeek = {
                                    "Monday",
                                    "Tuesday",
                                    "Wednesday",
                                    "Thursday",
                                    "Friday",
                                    "Saturday",
                                    "Sunday"
                                    };
            Assert.IsTrue(daysOfWeek.Length == 7);
            Assert.IsTrue(daysOfWeek[0].Equals("Monday"));
        }

        [TestMethod]
        public void Array_Initilization_Using_New_Test()
        {
            // Value Type Array
            var numbers = new int[5];
            Assert.IsTrue(numbers.Length == 5);
            foreach (var number in numbers)
            {
                Assert.IsTrue(number == 0);
            }

            // Reference Type Array
            var colors = new string[10];
            foreach (var color in colors)
            {
                Assert.IsTrue(color == null);
            }
        }

        [TestMethod]
        public void Array_Initilization_Using_Expression_Test()
        {
            int eight = 8;
            int[] squares = new int[]
            {
                1,
                2*2,
                eight + 1,
                int.Parse("16"),
                (int)Math.Sqrt(625)
            };
            foreach (var number in squares)
            {
                Console.WriteLine(number);
            }
            Assert.IsTrue(squares.Length == 5);
        }

        [TestMethod]
        public void Array_Iteration_Test()
        {
            string[] daysOfWeek = {
                                    "Monday",
                                    "Tuesday",
                                    "Wednesday",
                                    "Thursday",
                                    "Friday",
                                    "Saturday",
                                    "Sunday"
                                    };
            foreach (var day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }
    }
}
