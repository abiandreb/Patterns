namespace StatePattern.CombinationLock;

public class InputState(int[] combination, List<int> entered) : ILockState
{
    public string Status => string.Join("", entered);

    public ILockState EnterDigit(int digit)
    {
        var next = new List<int>(entered) { digit };

        if (digit != combination[next.Count - 1])
            return new ErrorState();

        if (next.Count == combination.Length)
            return new OpenState();

        return new InputState(combination, next);
    }
}
