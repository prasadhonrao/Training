using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace Training.CSharp
{
    [TestClass]
    public class RegexTests
    {
        [TestMethod]
        public void Regex_Split_Test()
        {
            var name = "Prasad Honrao";
            Regex exp = new Regex(" ");
            string[] output = exp.Split(name);
            Assert.AreEqual(2, output.Length);
        }

        [TestMethod]
        public void Regex_Replace_Test()
        {
            var name = "Prasad Honrao";
            Regex pattern = new Regex("[aeiou]");
            string output = pattern.Replace(name,"*");
            Console.WriteLine(output);
            Assert.AreEqual("Pr*s*d H*nr**", output);
        }

        [TestMethod]
        public void Regex_Split_By_Number_Test()
        {
            var colors = "Red0Orange1Yellow2Green3Black4White5PurpleYellow";
            Regex exp = new Regex(@"\d");
            string[] output = exp.Split(colors);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            Assert.AreEqual(7, output.Length);
        }

        [TestMethod]
        public void Regex_Match_Test()
        {
            string content = "This is a statement with hyphen (-) in it";
            Regex exp = new Regex("[^-]+");
            var match = exp.Match(content);
            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Didn't match");
            }
        }
    }
}
