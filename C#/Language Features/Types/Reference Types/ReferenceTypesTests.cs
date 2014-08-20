using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReferenceTypes
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
    }

    [TestClass]
    public class ReferenceTypesTests
    {
        [TestMethod]
        public void InstanceRefersToItSelfTest()
        {
            Employee emp = new Employee() { Id = 1, Name = "Prasad Honrao", Company = "Cognizant" };
            Assert.IsTrue(emp == emp);
        }

        [TestMethod]
        public void TwoDifferentInstancesTest()
        {
            Employee emp1 = new Employee() { Id = 1, Name = "Prasad Honrao", Company = "Cognizant" };
            Employee emp2 = new Employee() { Id = 2, Name = "Colin Gray", Company = "JPMC" };

            Assert.IsTrue(emp1 != emp2);
        }

        [TestMethod]
        public void InstanceNullTest()
        {
            Employee emp1 = new Employee() { Id = 1, Company = "Cognizant" };
            Assert.IsNotNull(emp1);
            Assert.IsNull(emp1.Name);
        }

        [TestMethod]
        public void TwoInstancesSameMemoryLocationTest()
        {
            Employee emp1 = new Employee() { Id = 1, Company = "Cognizant" };
            Employee emp2 = emp1;

            Assert.IsTrue(emp1 == emp2);
        }

        [TestMethod]
        public void TwoInstancesSameMemoryLocationValueChangeTest()
        {
            Employee emp1 = new Employee() { Id = 1, Company = "Cognizant" };
            Employee emp2 = new Employee() { Id = 2, Company = "JPMC" };

            emp1 = emp2;
            emp1.Id = 10;

            Assert.IsTrue(emp1 == emp2);
            Assert.IsTrue(emp1.Id == 10);
            Assert.IsTrue(emp2.Id == 10);
        }
    }
}
