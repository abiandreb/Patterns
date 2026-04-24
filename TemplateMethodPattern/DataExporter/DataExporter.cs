namespace TemplateMethodPattern.DataExporter;

public abstract class DataExporter
{
    // Template method
    public string Export(IReadOnlyList<Record> records)
    {
        var rows = records.Select(FormatRecord).ToList();
        var body = string.Join(Separator(), rows);

        var header = GenerateHeader();
        var footer = GenerateFooter(records.Count);

        return string.Concat(
            header is not null ? header + Environment.NewLine : "",
            body,
            footer is not null ? Environment.NewLine + footer : "");
    }

    protected abstract string FormatRecord(Record record);

    // Hooks with sensible defaults
    protected virtual string? GenerateHeader() => null;
    protected virtual string? GenerateFooter(int totalRecords) => null;
    protected virtual string Separator() => Environment.NewLine;
}
