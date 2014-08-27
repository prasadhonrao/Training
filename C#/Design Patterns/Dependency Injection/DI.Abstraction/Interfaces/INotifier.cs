using System;
using DI.Abstraction.Classes;

namespace DI.Abstraction.Interfaces
{
    public interface INotifier
    {
        void SendReceipt(OrderInfo orderInfo);
    }
}
