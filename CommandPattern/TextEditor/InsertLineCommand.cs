namespace CommandPattern.TextEditor;

public class InsertLineCommand(Document document, int index, string text) : ITextCommand
{
    public void Execute() => document.InsertLine(index, text);
    public void Undo() => document.RemoveLine(index);
}
