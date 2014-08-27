using DI.Abstraction.Classes;
using DI.Abstraction.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DI.Abstraction.Tests
{
    [TestClass]
    public class CommerceTest
    {
        [TestMethod]
        public void Commerce_Constructor_Test()
        {
            // Arrange
            var mockBilling = new Mock<IBillingProcessor>();
            var mockCustomer = new Mock<ICustomerProcessor>();
            var mockNotifer = new Mock<INotifier>();
            var mockLogger = new Mock<ILogger>();

            // Act
            var commerce = new Commerce(mockBilling.Object, mockCustomer.Object, mockNotifer.Object, mockLogger.Object);

            // Assert
            Assert.IsNotNull(commerce);
        }

        [TestMethod]
        public void Commerce_ProcessOrder_Test()
        {
            // Arrange
            var mockBilling = new Mock<IBillingProcessor>();
            var mockCustomer = new Mock<ICustomerProcessor>();
            var mockNotifer = new Mock<INotifier>();
            var mockLogger = new Mock<ILogger>();

            mockBilling.Setup(obj => obj.ProcessPayment(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>()));
            mockCustomer.Setup(obj => obj.UpdateCustomer(It.IsAny<string>()));
            mockNotifer.Setup(obj => obj.SendReceipt(It.IsAny<OrderInfo>()));
            mockLogger.Setup(obj => obj.Log(It.IsAny<string>()));

            // Act
            var commerce = new Commerce(mockBilling.Object, mockCustomer.Object, mockNotifer.Object, mockLogger.Object);
            commerce.ProcessOrder(new OrderInfo());

            // Assert
            mockBilling.VerifyAll();
            mockCustomer.VerifyAll();
            mockNotifer.VerifyAll();
            mockLogger.VerifyAll();
        }
    }
}
