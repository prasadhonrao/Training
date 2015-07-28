using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        public void Array_Initilization_Using_Object_Type_Test()
        {
            object[] objects = new object[]
            {
                "Hello",
                Guid.NewGuid(),
                12,
                new System.IO.FileInfo(@"C:\Windows\Notepad.exe")
            };
            foreach (var item in objects)
            {
                Console.WriteLine(item);
            }
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

        [TestMethod]
        public void Array_Modification_Using_For_Test()
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
            for (int index = 0; index < daysOfWeek.Length; index++)
            {
                daysOfWeek[index] = daysOfWeek[index] + "s";
            }

            // Foreach is a readonly loop, cant be used to modify array elements like for loop
            foreach (var day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }

        [TestMethod]
        public void Array_Reference_Equality_Test()
        {
            int[] x1 = { 1, 2, 3, 4, 5 };
            var x2 = x1;
            x1[0] = 10;

            int[] x3 = { 1, 2, 3, 4, 5 };

            Assert.IsTrue(x2[0] == 10);
            Assert.IsTrue(x1 == x2);
            Assert.IsFalse(x1 == x3);
        }

        [TestMethod]
        public void Array_Copy_Test()
        {
            int[] X1 = { 1, 2, 3, 4, 5 };
            int[] X2 = new int[5];
            X1.CopyTo(X2, 0);
            foreach (var item in X2)
            {
                Console.WriteLine(item);
            }
            Assert.IsTrue(X2.Length == 5);
            Assert.IsTrue(X1 != X2);

            // Array class static method
            int[] X3 = new int[5];
            System.Array.Copy(X1, X3, 5);
            foreach (var item in X3)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void Array_Reverse_Test()
        {
            // Using Array.Reverse static method
            int[] numbers = { 1, 2, 3, 4, 5 };
            System.Array.Reverse(numbers);
            Assert.IsTrue(numbers[0] == 5);

            // Using Extension method
            int[] numbers2 = { 1, 2, 3, 4, 5 };
            var numbers3 = numbers2.Reverse().ToArray();
            Assert.IsTrue(numbers3[0] == 5);
        }

        [TestMethod]
        public void Array_Sort_Test()
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
            System.Array.Sort(daysOfWeek);
            foreach (var day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }

        [TestMethod]
        public void Array_Sort_Using_ComparerTest()
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
            var comparer = new StringLengthComparer();
            System.Array.Sort(daysOfWeek, comparer);
            foreach (var day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }

        [TestMethod]
        public void Array_BinarySeary_Test()
        {
            int[] numbers = Enumerable.Range(1, 100000000).ToArray();
            var index1 = System.Array.IndexOf(numbers, 5555555);

            // BinarySearch is much faster in case of large collection, however collection must be sorted
            var index2 = System.Array.BinarySearch(numbers, 5555555);
            Console.WriteLine(index1);
            Console.WriteLine(index2);
        }
    }

    public class StringLengthComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.Length.CompareTo(y.Length);
        }
    }
}
