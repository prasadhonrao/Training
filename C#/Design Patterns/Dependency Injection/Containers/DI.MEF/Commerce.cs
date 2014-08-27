using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using DI.MEF.Classes;
using DI.MEF.Interfaces;

namespace DI.MEF
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class Commerce
    {
        #region Constuctor Injection
        //private IBillingProcessor _billingProcessor;
        //private ICustomerProcessor _customerProcessor;
        //private INotifier _notifier;
        //private ILogger _logger;

        //[ImportingConstructor]
        //public Commerce(IBillingProcessor billingProcessor,
        //    ICustomerProcessor customerProcessor,
        //    INotifier notifier,
        //    ILogger logger)
        //{
        //    _billingProcessor = billingProcessor;
        //    _customerProcessor = customerProcessor;
        //    _notifier = notifier;
        //    _logger = logger;
        //}
        
        #endregion

        #region Property Injection
        [Import]
        private IBillingProcessor _billingProcessor;
        [Import]
        private ICustomerProcessor _customerProcessor;
        [Import]
        private INotifier _notifier;
        [Import]
        private ILogger _logger;

        [ImportingConstructor]
        public Commerce()
        {
        } 
        #endregion

        public void ProcessOrder(OrderInfo orderInfo)
        {
            _billingProcessor.ProcessPayment(orderInfo.CustomerName, orderInfo.CreditCard, orderInfo.Price);
            _logger.Log("Billing processed");
            _customerProcessor.UpdateCustomer(orderInfo.CustomerName);
            _logger.Log("Updated to customer");
            _notifier.SendReceipt(orderInfo);
            _logger.Log("Receipt sent");
        }
    }
}
