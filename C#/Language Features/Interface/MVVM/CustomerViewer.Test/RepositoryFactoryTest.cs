using CustomerRepository.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CustomerViewer.Test
{
    [TestClass]
    public class RepositoryFactoryTest
    {
        [TestMethod]
        public void GetRepository_Test()
        {
            // Arrange + Act
            var repo = RepositoryFactory.GetRepository();

            // Assert
            Assert.IsNotNull(repo);
            Assert.IsTrue(repo.GetType().FullName.Equals("CustomerRepository.Fake.FakeRepository", StringComparison.OrdinalIgnoreCase));
        }
    }
}
