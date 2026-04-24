namespace CommandPattern.TextEditor;

public class ReplaceLineCommand(Document document, int index, string newText) : ITextCommand
{
    private string _previousText = string.Empty;

    public void Execute()
    {
        _previousText = document.Lines[index];
        document.ReplaceLine(index, newText);
    }

    public void Undo() => document.ReplaceLine(index, _previousText);
}
