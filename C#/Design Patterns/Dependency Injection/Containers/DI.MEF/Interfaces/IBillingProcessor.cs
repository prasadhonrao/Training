namespace DI.MEF.Interfaces
{
    public interface IBillingProcessor
    {
        void ProcessPayment(string customerName, int creditCard, int price);
    }
}
