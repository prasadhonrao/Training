using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValueTypes
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
    }

    [TestClass]
    public class ValueTypeTest
    {
        [TestMethod]
        public void TwoIntsTest()
        {
            int x = 5;
            int y = 10;
            Assert.IsFalse(x == y);
        }

        [TestMethod]
        public void TwoIntAssignmentTest()
        {
            int x = 5;
            int y = 10;
            x = y;
            Assert.IsTrue(x == y);
        }

        [TestMethod]
        public void IntReferenceTypeTest()
        {
            int x = 1;
            Employee emp1 = new Employee() { Id = 1, Name = "Prasad Honrao", Company = "Cognizant" };
            Assert.IsTrue(x == emp1.Id);
            Assert.IsFalse((object)x == emp1);
        }
    }
}
