namespace AdapterPattern.Payment;

/// <summary>
/// Simulates PayPal's third-party SDK with its own interface.
/// </summary>
public class PayPalSdk
{
    public bool MakePayment(string receiver, double total, string curr)
    {
        Console.WriteLine($"  [PayPal SDK] Payment of {total:F2} {curr} to '{receiver}' completed");
        return true;
    }
}
