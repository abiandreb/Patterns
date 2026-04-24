namespace FactoryPattern.Notification;

public interface INotification
{
    string Channel { get; }
    void Send(string recipient, string message);
}
