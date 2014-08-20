using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Training.CSharp
{
    [TestClass]
    public class ParametersTest
    {
        [TestMethod]
        public void PassByValueTest()
        {
            var emp = new Employee() { Id = 1, Name = "Prasad Honrao" };
            int age = 30;
            DoWord_PassByValueTest(emp, age);

            Assert.IsTrue(emp.Id == 2);
            Assert.IsTrue(age == 30);
        }

        private void DoWord_PassByValueTest(Employee emp, int age)
        {
            emp.Id = 2;
            age = 32;
        }

        [TestMethod]
        public void PassByValueTestNewInstance()
        {
            var emp = new Employee() { Id = 1, Name = "Prasad Honrao" };
            int age = 30;
            DoWord_PassByValueTestNewInstance(emp, age);

            Assert.IsTrue(emp.Id == 1);
            Assert.IsTrue(age == 30);
        }

        private void DoWord_PassByValueTestNewInstance(Employee emp, int age)
        {
            emp = new Employee();
            emp.Id = 2;
            age = 32;
        }

        [TestMethod]
        public void PassByReferenceTest()
        {
            var emp = new Employee() { Id = 1, Name = "Prasad Honrao" };
            int age = 30;
            DoWord_PassByReferenceTest(ref emp, ref age);

            Assert.IsTrue(emp.Id == 2);
            Assert.IsTrue(age == 32);
        }

        private void DoWord_PassByReferenceTest(ref Employee emp, ref int age)
        {
            // Even though new instance is created, it will still refer to original reference type
            emp = new Employee();
            emp.Id = 2;
            age = 32;
        }

        [TestMethod]
        public void OutParameterTest()
        {
            var emp = new Employee() { Id = 1, Name = "Prasad Honrao" };
            int age;
            DoWord_OutParameterTest(emp, out age);

            Assert.IsTrue(emp.Id == 2);
            Assert.IsTrue(age == 32);
        }

        private void DoWord_OutParameterTest(Employee emp, out int age)
        {
            emp.Id = 2;
            age = 32;
        }
    }
}
