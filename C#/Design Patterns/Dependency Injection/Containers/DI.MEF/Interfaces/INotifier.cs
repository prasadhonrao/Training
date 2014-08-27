using System;
using DI.MEF.Classes;

namespace DI.MEF.Interfaces
{
    public interface INotifier
    {
        void SendReceipt(OrderInfo orderInfo);
    }
}
