namespace CommandPattern.TextEditor;

public interface ITextCommand
{
    void Execute();
    void Undo();
}
