namespace DI.Abstraction.Interfaces
{
    public interface IBillingProcessor
    {
        void ProcessPayment(string customerName, int creditCard, int price);
    }
}
