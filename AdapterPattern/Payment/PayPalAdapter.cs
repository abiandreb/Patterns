namespace AdapterPattern.Payment;

public class PayPalAdapter(PayPalSdk payPalSdk) : IPaymentProcessor
{
    public string Name => "PayPal";

    public bool ProcessPayment(string merchantId, decimal amount, string currency)
    {
        return payPalSdk.MakePayment(merchantId, (double)amount, currency);
    }
}
