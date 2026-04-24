namespace DecoratorPattern.Notifier;

public class EmailNotifier(string email) : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine($"  [Email] Sending to {email}: {message}");
    }
}
