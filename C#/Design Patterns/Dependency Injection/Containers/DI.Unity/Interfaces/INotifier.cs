using System;
using DI.Unity.Classes;

namespace DI.Unity.Interfaces
{
    public interface INotifier
    {
        void SendReceipt(OrderInfo orderInfo);
    }
}
