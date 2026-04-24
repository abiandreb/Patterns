namespace MementoPattern.TextEditor;

// Caretaker — manages undo/redo stacks without knowing memento internals
public class EditorHistory
{
    private readonly TextEditor _editor;
    private readonly Stack<EditorMemento> _undoStack = new();
    private readonly Stack<EditorMemento> _redoStack = new();

    public EditorHistory(TextEditor editor)
    {
        _editor = editor;
    }

    public void SaveState()
    {
        _undoStack.Push(_editor.Save());
        _redoStack.Clear();
    }

    public bool Undo()
    {
        if (_undoStack.Count == 0) return false;

        _redoStack.Push(_editor.Save());
        _editor.Restore(_undoStack.Pop());
        return true;
    }

    public bool Redo()
    {
        if (_redoStack.Count == 0) return false;

        _undoStack.Push(_editor.Save());
        _editor.Restore(_redoStack.Pop());
        return true;
    }

    public int UndoCount => _undoStack.Count;
    public int RedoCount => _redoStack.Count;
}
