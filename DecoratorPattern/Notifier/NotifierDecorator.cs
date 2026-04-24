namespace DecoratorPattern.Notifier;

public abstract class NotifierDecorator(INotifier inner) : INotifier
{
    protected INotifier Inner => inner;

    public virtual void Send(string message) => inner.Send(message);
}
