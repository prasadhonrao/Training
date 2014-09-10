using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Introduction
{
    [TestClass]
    public class ArrayTests
    {
        [TestMethod]
        public void Array_Declaration_Test()
        {
            // Once array length is declared, it cannot be changed
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;
            Assert.AreEqual(5, array.Length);
        }

        [TestMethod]
        public void Array_Iteration_Test()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void String_Array_Iteration_Test()
        {
            string[] colors = { "Red", "Green", "Blue" };
            foreach (var item in colors)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void String_Array_Declaration_And_Iteration_Test()
        {
            string[] teams = new string[3] { "India", "Australia", "England" };
            foreach (var item in teams)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void Object_Array_Iteration_Test()
        {
            object[] objects = new object[] { 1, "One", "1+1" };
            foreach (var item in objects)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void Array_Class_Iteration_Test()
        {
            Array odds = new[] { 1, 3, 5, 7, 9 };
            foreach (var item in odds)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void Array_Sort_Test()
        {
            var rainbowColors = new string[7];
            rainbowColors[0] = "Red";
            rainbowColors[1] = "Orange";
            rainbowColors[2] = "Yellow";
            rainbowColors[3] = "Green";
            rainbowColors[4] = "Blue";
            rainbowColors[5] = "Indigo";
            rainbowColors[6] = "Violet";

            Array.Sort(rainbowColors);
            foreach (var color in rainbowColors)
            {
                Console.WriteLine(color);
            }
        }

        [TestMethod]
        public void Array_IndexOf_Test()
        {
            var rainbowColors = new string[7];
            rainbowColors[0] = "Red";
            rainbowColors[1] = "Orange";
            rainbowColors[2] = "Yellow";
            rainbowColors[3] = "Green";
            rainbowColors[4] = "Blue";
            rainbowColors[5] = "Indigo";
            rainbowColors[6] = "Violet";

            int validIndex = Array.IndexOf(rainbowColors, "Yellow");
            int invalidIndex = Array.IndexOf(rainbowColors, "Black");

            Assert.IsTrue(validIndex == 2);
            Assert.IsTrue(invalidIndex == -1);
        }

        [TestMethod]
        public void Array_BinarySearch_Test()
        {
            var rainbowColors = new string[7];
            rainbowColors[0] = "Red";
            rainbowColors[1] = "Orange";
            rainbowColors[2] = "Yellow";
            rainbowColors[3] = "Green";
            rainbowColors[4] = "Blue";
            rainbowColors[5] = "Indigo";
            rainbowColors[6] = "Violet";

            int blueColorExists = Array.BinarySearch(rainbowColors, "Blue");
            Console.WriteLine(blueColorExists);
            //Assert.IsTrue(blueColorExists >= 0);
        }

        [TestMethod]
        public void Array_Lambda_Test()
        {
            var rainbowColors = new string[7];
            rainbowColors[0] = "Red";
            rainbowColors[1] = "Orange";
            rainbowColors[2] = "Yellow";
            rainbowColors[3] = "Green";
            rainbowColors[4] = "Blue";
            rainbowColors[5] = "Indigo";
            rainbowColors[6] = "Violet";

            Array.ForEach(rainbowColors, r =>
            {
                Console.WriteLine(r.ToString() + " "  + r.Length);
            });
        }

        [TestMethod]
        public void Array_Clone_Test()
        {
            var weekdays = new[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            string[] clonedWeekdays = (string[])weekdays.Clone();

            var original = weekdays[0];
            var cloned = clonedWeekdays[0];

            var sameReference = Object.ReferenceEquals(original, cloned);
            Assert.IsTrue(sameReference);
        }


        [TestMethod]
        public void Array_Multidimenstion_Test()
        {
            var board = new char[2, 2];
            board[0, 0] = 'A';
            board[0, 1] = 'B';
            board[1, 0] = 'C';
            board[1, 1] = 'D';
            Assert.IsTrue(board.Length == 4);
        }
    }
}
