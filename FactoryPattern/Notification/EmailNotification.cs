namespace FactoryPattern.Notification;

public class EmailNotification : INotification
{
    public string Channel => "Email";

    public void Send(string recipient, string message) =>
        Console.WriteLine($"  [EMAIL] To: {recipient} | Subject: {message}");
}
