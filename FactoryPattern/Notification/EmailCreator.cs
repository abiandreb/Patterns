namespace FactoryPattern.Notification;

public class EmailCreator : NotificationCreator
{
    protected override INotification CreateNotification() => new EmailNotification();
}
