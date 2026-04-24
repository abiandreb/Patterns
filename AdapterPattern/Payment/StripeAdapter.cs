namespace AdapterPattern.Payment;

public class StripeAdapter(StripeApi stripeApi) : IPaymentProcessor
{
    public string Name => "Stripe";

    public bool ProcessPayment(string merchantId, decimal amount, string currency)
    {
        var amountInCents = (long)(amount * 100);
        var chargeId = stripeApi.CreateCharge(amountInCents, currency, $"Payment to {merchantId}");
        Console.WriteLine($"  [Stripe Adapter] Charge ID: {chargeId}");
        return chargeId is not null;
    }
}
