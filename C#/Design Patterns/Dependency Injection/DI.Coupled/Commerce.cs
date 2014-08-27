using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DI.Coupled
{
    public class Commerce
    {
        private BillingProcessor _billingProcessor;
        private CustomerProcessor _customerProcessor;
        private Notifier _notifier;
        private Logger _logger;

        public Commerce(BillingProcessor billingProcessor,
                        CustomerProcessor customerProcessor,
                        Notifier notifier,
                        Logger logger)
        {
            _billingProcessor = billingProcessor;
            _customerProcessor = customerProcessor;
            _notifier = notifier;
            _logger = logger;
        }

        internal void ProcessOrder(OrderInfo orderInfo)
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
