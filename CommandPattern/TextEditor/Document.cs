namespace CommandPattern.TextEditor;

public class Document
{
    private readonly List<string> _lines = [];

    public IReadOnlyList<string> Lines => _lines;

    public void InsertLine(int index, string text)
    {
        _lines.Insert(index, text);
    }

    public string RemoveLine(int index)
    {
        var line = _lines[index];
        _lines.RemoveAt(index);
        return line;
    }

    public void ReplaceLine(int index, string text)
    {
        _lines[index] = text;
    }

    public void Print()
    {
        if (_lines.Count == 0)
        {
            Console.WriteLine("  (empty document)");
            return;
        }

        for (var i = 0; i < _lines.Count; i++)
            Console.WriteLine($"  {i + 1}| {_lines[i]}");
    }
}
