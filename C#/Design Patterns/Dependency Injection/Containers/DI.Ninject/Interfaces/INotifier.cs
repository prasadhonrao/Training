using System;
using DI.NInject.Classes;

namespace DI.NInject.Interfaces
{
    public interface INotifier
    {
        void SendReceipt(OrderInfo orderInfo);
    }
}
