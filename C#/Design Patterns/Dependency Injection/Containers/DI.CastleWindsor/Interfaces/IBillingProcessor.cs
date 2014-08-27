namespace DI.CastleWindsor.Interfaces
{
    public interface IBillingProcessor
    {
        void ProcessPayment(string customerName, int creditCard, int price);
    }
}
