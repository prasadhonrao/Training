using System;
using DI.StructureMap.Classes;

namespace DI.StructureMap.Interfaces
{
    public interface INotifier
    {
        void SendReceipt(OrderInfo orderInfo);
    }
}
