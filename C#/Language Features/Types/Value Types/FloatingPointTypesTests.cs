using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Training.CSharp
{
    [TestClass]
    public class FloatingPointTypesTests
    {
        [TestMethod]
        public void FloatingPoint_Declaration_Test()
        {
            float f = 0.2f;
            double d = 0.2d;
            decimal m = 0.2m;

            Assert.IsTrue(f.GetType() == typeof(float));
            Assert.IsTrue(d.GetType() == typeof(double));
            Assert.IsTrue(m.GetType() == typeof(decimal));
        }

        [TestMethod]
        public void Double_Type_Division_Test()
        {
            double d = 50 / 100;
            Assert.AreEqual(0, d);
        }

        [TestMethod]
        public void Double_Type_Division_Test_2()
        {
            double d = (double)50 / 100;
            Assert.AreEqual(0.5, d);
        }

        [TestMethod]
        public void Double_Type_Division_Test_3()
        {
            double d = 50.0 / 100.0;
            Assert.AreEqual(0.5, d);
        }

        [TestMethod]
        public void Double_Type_Addition_Gotcha_Test()
        {
            double d = 0.1;
            d +=       0.000001;
            d +=       0.000001;
            d +=       0.000001;
            d +=       0.000001;
            d +=       0.000001;


            Console.WriteLine(d);
            Console.WriteLine(DoubleConverter.ToExactString(d));
            Assert.AreNotEqual(0.100005, d); //!!! Double value will always be too long and actual value wont be shown in most of the cases.
        }

        [TestMethod]
        public void Double_NaN_Equality_Test()
        {
            double d1 = double.NaN;
            double d2 = double.NaN;
            Assert.IsFalse(d1 == d2); // NaN are not equal to each other
        }
    }
}
