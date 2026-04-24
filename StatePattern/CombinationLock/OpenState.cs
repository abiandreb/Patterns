namespace StatePattern.CombinationLock;

public class OpenState : ILockState
{
    public string Status => "OPEN";

    public ILockState EnterDigit(int digit) => this;
}
