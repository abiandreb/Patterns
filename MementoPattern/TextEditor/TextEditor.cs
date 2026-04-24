namespace MementoPattern.TextEditor;

// Originator — the object whose state we want to save and restore
public class TextEditor
{
    public string Content { get; private set; } = string.Empty;
    public int CursorPosition { get; private set; }

    public void Type(string text)
    {
        Content = Content.Insert(CursorPosition, text);
        CursorPosition += text.Length;
    }

    public void MoveCursor(int position)
    {
        CursorPosition = Math.Clamp(position, 0, Content.Length);
    }

    public void DeleteRange(int start, int length)
    {
        start = Math.Clamp(start, 0, Content.Length);
        length = Math.Min(length, Content.Length - start);
        Content = Content.Remove(start, length);
        CursorPosition = Math.Min(CursorPosition, Content.Length);
    }

    public EditorMemento Save() => new(Content, CursorPosition, DateTime.Now);

    public void Restore(EditorMemento memento)
    {
        Content = memento.Content;
        CursorPosition = memento.CursorPosition;
    }

    public override string ToString() =>
        $"\"{Content}\" (cursor at {CursorPosition})";
}
