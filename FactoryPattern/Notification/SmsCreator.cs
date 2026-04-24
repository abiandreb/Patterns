namespace FactoryPattern.Notification;

public class SmsCreator : NotificationCreator
{
    protected override INotification CreateNotification() => new SmsNotification();
}
