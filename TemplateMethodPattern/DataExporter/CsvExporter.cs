namespace TemplateMethodPattern.DataExporter;

public class CsvExporter : DataExporter
{
    protected override string? GenerateHeader() => "Name,Age,City";
    protected override string FormatRecord(Record record) => $"{record.Name},{record.Age},{record.City}";
}
