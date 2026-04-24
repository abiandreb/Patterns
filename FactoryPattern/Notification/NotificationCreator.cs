namespace FactoryPattern.Notification;

// Creator — declares the factory method and contains shared delivery logic
public abstract class NotificationCreator
{
    // Factory Method — subclasses decide which INotification to create
    protected abstract INotification CreateNotification();

    public void Notify(string recipient, string message)
    {
        var notification = CreateNotification();
        Console.WriteLine($"  Preparing {notification.Channel} notification...");
        notification.Send(recipient, message);
    }
}
