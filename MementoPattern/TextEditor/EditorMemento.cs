namespace MementoPattern.TextEditor;

// Memento — immutable snapshot of the editor state
public record EditorMemento(string Content, int CursorPosition, DateTime SavedAt);
