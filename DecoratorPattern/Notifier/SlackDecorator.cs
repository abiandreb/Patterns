namespace DecoratorPattern.Notifier;

public class SlackDecorator(INotifier inner, string channel) : NotifierDecorator(inner)
{
    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"  [Slack] Posting to #{channel}: {message}");
    }
}
