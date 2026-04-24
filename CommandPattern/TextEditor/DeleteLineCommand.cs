namespace CommandPattern.TextEditor;

public class DeleteLineCommand(Document document, int index) : ITextCommand
{
    private string _deletedText = string.Empty;

    public void Execute() => _deletedText = document.RemoveLine(index);
    public void Undo() => document.InsertLine(index, _deletedText);
}
