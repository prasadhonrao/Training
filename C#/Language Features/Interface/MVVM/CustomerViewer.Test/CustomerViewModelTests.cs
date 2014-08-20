using CustomerRepository.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CustomerViewer.Test
{
    [TestClass]
    public class CustomerViewModelTests
    {
        [TestMethod]
        public void GetCustomers_Test()
        {
            // Arrange
            var viewModel = new CustomerViewModel();

            // Act
            viewModel.GetCustomers();

            // Assert
            Assert.IsNotNull(viewModel.Customers);
            Assert.AreEqual(2, viewModel.Customers.Count());
            Assert.IsTrue(viewModel.Customers.All(c => c.Name.Contains("Fake")));
        }

        [TestMethod]
        public void ClearCustomers_Test()
        {
            // Arrange
            var viewModel = new CustomerViewModel();

            // Act
            viewModel.ClearCustomers();

            // Assert
            Assert.IsNotNull(viewModel.Customers);
            Assert.AreEqual(0, viewModel.Customers.Count());
        }
    }
}
