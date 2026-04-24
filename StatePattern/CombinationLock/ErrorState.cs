namespace StatePattern.CombinationLock;

public class ErrorState : ILockState
{
    public string Status => "ERROR";

    public ILockState EnterDigit(int digit) => this;
}
