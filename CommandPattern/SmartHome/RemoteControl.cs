namespace CommandPattern.SmartHome;

public class RemoteControl
{
    private readonly Stack<ICommand> _history = new();

    public void Press(ICommand command)
    {
        Console.WriteLine($"  [Remote] Executing: {command.Name}");
        command.Execute();
        _history.Push(command);
    }

    public void UndoLast()
    {
        if (_history.Count == 0)
        {
            Console.WriteLine("  [Remote] Nothing to undo");
            return;
        }

        var command = _history.Pop();
        Console.WriteLine($"  [Remote] Undoing: {command.Name}");
        command.Undo();
    }
}
