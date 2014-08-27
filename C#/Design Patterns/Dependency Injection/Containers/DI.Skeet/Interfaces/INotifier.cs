using System;
using DI.Skeet.Classes;

namespace DI.Skeet.Interfaces
{
    public interface INotifier
    {
        void SendReceipt(OrderInfo orderInfo);
    }
}
