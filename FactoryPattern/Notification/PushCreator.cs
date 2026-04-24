namespace FactoryPattern.Notification;

public class PushCreator : NotificationCreator
{
    protected override INotification CreateNotification() => new PushNotification();
}
