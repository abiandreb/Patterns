namespace FactoryPattern.Notification;

public class SmsNotification : INotification
{
    public string Channel => "SMS";

    public void Send(string recipient, string message) =>
        Console.WriteLine($"  [SMS] To: {recipient} | Text: {message}");
}
