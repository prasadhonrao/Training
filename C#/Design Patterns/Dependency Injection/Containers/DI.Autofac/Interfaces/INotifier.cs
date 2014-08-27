using System;
using DI.Autofac.Classes;

namespace DI.Autofac.Interfaces
{
    public interface INotifier
    {
        void SendReceipt(OrderInfo orderInfo);
    }
}
