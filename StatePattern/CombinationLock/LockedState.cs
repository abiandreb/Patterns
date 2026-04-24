namespace StatePattern.CombinationLock;

public class LockedState(int[] combination) : ILockState
{
    public string Status => "LOCKED";

    public ILockState EnterDigit(int digit)
    {
        if (digit == combination[0])
            return new InputState(combination, [digit]);

        return new ErrorState();
    }
}
