namespace AdapterPattern.Payment;

/// <summary>
/// Simulates Stripe's third-party API with its own interface.
/// </summary>
public class StripeApi
{
    public string CreateCharge(long amountInCents, string currencyCode, string description)
    {
        Console.WriteLine($"  [Stripe API] Charge created: {amountInCents} cents ({currencyCode}) - {description}");
        return $"ch_{Guid.NewGuid().ToString()[..8]}";
    }
}
