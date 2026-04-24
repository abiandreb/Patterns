namespace DecoratorPattern.Notifier;

public class SmsDecorator(INotifier inner, string phoneNumber) : NotifierDecorator(inner)
{
    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"  [SMS] Texting {phoneNumber}: {message}");
    }
}
