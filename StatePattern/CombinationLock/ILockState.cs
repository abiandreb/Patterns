namespace StatePattern.CombinationLock;

public interface ILockState
{
    string Status { get; }
    ILockState EnterDigit(int digit);
}
