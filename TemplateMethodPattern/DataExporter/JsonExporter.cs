namespace TemplateMethodPattern.DataExporter;

public class JsonExporter : DataExporter
{
    protected override string? GenerateHeader() => "[";
    protected override string FormatRecord(Record record) =>
        $"  {{ \"name\": \"{record.Name}\", \"age\": {record.Age}, \"city\": \"{record.City}\" }}";
    protected override string? GenerateFooter(int totalRecords) => "]";
    protected override string Separator() => "," + Environment.NewLine;
}
