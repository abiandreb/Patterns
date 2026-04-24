namespace AdapterPattern.Payment;

public interface IPaymentProcessor
{
    string Name { get; }
    bool ProcessPayment(string merchantId, decimal amount, string currency);
}
