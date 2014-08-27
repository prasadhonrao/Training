using System;
using DI.CastleWindsor.Classes;

namespace DI.CastleWindsor.Interfaces
{
    public interface INotifier
    {
        void SendReceipt(OrderInfo orderInfo);
    }
}
