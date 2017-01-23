using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace Training.CSharp
{
    [TestClass]
    public class StringTests
    {
        [TestMethod]
        public void String_With_Same_Content_Equal_Test()
        {
            string first = "hello";
            string second = "hello";
            Assert.AreEqual(first, second);
            Assert.AreSame(first, second); //check if strings refers to same object in memory
        }

        [TestMethod]
        public void String_Different_Case_Are_Not_Equal_Test()
        {
            string first = "hello";
            string second = "Hello";
            Assert.AreNotEqual(first, second);
        }

        [TestMethod]
        public void String_Two_Instance_Equal_Test()
        {
            string first = "hello";
            string second = first;
            Assert.AreEqual(first, second);
        }

        [TestMethod]
        public void String_Immutability_Test()
        {
            string first = "hello";
            first = first.Replace('h', 'j');
            Assert.AreEqual(first, "jello");
        }

        [TestMethod]
        public void String_Immutability_And_Copy_Test()
        {
            string first = "hello";
            string second = first;
            first = first.Replace('h', 'j');
            Console.WriteLine(first);
            Console.WriteLine(second);
            Assert.IsTrue(second == "hello");
        }

        [TestMethod]
        public void String_And_Object_Reference_Equality_Test()
        {
            string first = "hello";
            string second = "hello";
            object o1 = first;
            object o2 = second;
            Assert.AreEqual(o1, o2);
            Assert.IsTrue(o1 == o2);
            Assert.IsTrue(o1.Equals(o2));
        }

        [TestMethod]
        public void String_Concatenation_Equal_Test()
        {
            string first = "hello";
            string second = "he" + "llo";
            Assert.AreEqual(first, second);
            Assert.AreSame(first, second); //check if strings refers to same object in memory
        }

        [TestMethod]
        public void String_Concatenation_Equal_Without_Constant_Test()
        {
            string he = "he";
            string first = he + "llo";
            string second = "hello";
            Assert.AreEqual(first, second); // this checks only the 'value' is equal or not
            Assert.AreNotSame(first, second); // Even though we know 'he' is a static string, compiler doesn't know anything about it, hence it doesn't refer to same memory location
        }

        [TestMethod]
        public void String_Concatenation_Equal_With_Constant_Test()
        {
            const string he = "he";
            string first = he + "llo"; // creates new string every time this code executes
            string second = "hello";
            Assert.AreEqual(first, second); // this checks only the 'value' is equal or not
            Assert.AreSame(first, second); // Even though we know 'he' is a static string, compiler doesn't know anything about it, hence it doesn't refer to same memory location
        }

        [TestMethod]
        public void String_Bad_Concatenation_Test()
        {
            string simple = new string('X', 100000);

            string bad = "";
            for (int i = 0; i < 100000; i++) // creates new string for each iteration
            {
                bad = bad + "X";
            }

            Assert.AreEqual(simple, bad);
        }

        [TestMethod]
        public void String_Good_Concatenation_Using_StringBuilder_Test()
        {
            string simple = new string('X', 100000);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 100000; i++) // 
            {
                sb = sb.Append("X"); // adds X to buffer, but wont create new string each time
            }

            Assert.AreEqual(simple, sb.ToString());
        }

        [TestMethod]
        public void String_Good_Concatenation_Using_String_Test()
        {
            string x = "x";
            string y = "y";
            string result = x + " " + y;
            Assert.AreEqual("x y" , result);
        }

        [TestMethod]
        public void String_Compiler_Translation_Of_Concatenation_Using_String_Test()
        {
            string x = "x";
            string y = "y";
            string result = string.Concat(x, " ", y);
            Assert.AreEqual("x y", result);
        }

        [TestMethod]
        public void String_Join_Test()
        {
            string[] colors = { "red", "blue", "green"};
            string commaColors = string.Join(", ", colors);
            Assert.AreEqual("red, blue, green", commaColors);
        }

        [TestMethod]
        public void String_Split_Test()
        {
            string name = "Prasad Honrao";
            string[] result = name.Split(new char[] {' '});
            Assert.IsTrue(result.Length == 2);
            Assert.AreEqual(result[0], "Prasad");
        }

        [TestMethod]
        public void String_Split_Using_Comma_Test()
        {
            string numbers = "1, 2, 3, 4, 5, 6, 7";
            string[] result = numbers.Split(new char[] {','});
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
            Assert.IsTrue(result.Length == 7);
        }

        [TestMethod]
        public void String_Split_Using_Comma_Missing_Value_Test()
        {
            string numbers = "1,, 3,, 5, 6, 7";
            string[] result = numbers.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
            Assert.IsTrue(result.Length == 5);
        }
    }
}
