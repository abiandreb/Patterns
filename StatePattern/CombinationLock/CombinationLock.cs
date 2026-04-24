namespace StatePattern.CombinationLock;

public class CombinationLock
{
    private ILockState _state;

    public CombinationLock(int[] combination)
    {
        _state = new LockedState(combination);
    }

    public string Status => _state.Status;

    public void EnterDigit(int digit)
    {
        _state = _state.EnterDigit(digit);
        Console.WriteLine($"  Entered {digit} → Status: {Status}");
    }
}
