namespace FactoryPattern.Notification;

public class PushNotification : INotification
{
    public string Channel => "Push";

    public void Send(string recipient, string message) =>
        Console.WriteLine($"  [PUSH] To device: {recipient} | Alert: {message}");
}
