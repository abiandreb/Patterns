namespace CommandPattern.TextEditor;

public class DocumentEditor(Document document)
{
    private readonly Stack<ITextCommand> _undoStack = new();
    private readonly Stack<ITextCommand> _redoStack = new();

    public void Execute(ITextCommand command)
    {
        command.Execute();
        _undoStack.Push(command);
        _redoStack.Clear();
    }

    public bool Undo()
    {
        if (_undoStack.Count == 0) return false;
        var command = _undoStack.Pop();
        command.Undo();
        _redoStack.Push(command);
        return true;
    }

    public bool Redo()
    {
        if (_redoStack.Count == 0) return false;
        var command = _redoStack.Pop();
        command.Execute();
        _undoStack.Push(command);
        return true;
    }

    public void Print() => document.Print();
}
