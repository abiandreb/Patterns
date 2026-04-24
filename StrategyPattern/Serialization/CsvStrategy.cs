namespace StrategyPattern.Serialization;

public class CsvStrategy : ISerializationStrategy
{
    public string Serialize(List<Person> people)
    {
        var lines = new List<string> { "Name,Age,City" };
        lines.AddRange(people.Select(p => $"{p.Name},{p.Age},{p.City}"));
        return string.Join(Environment.NewLine, lines);
    }

    public List<Person> Deserialize(string data)
    {
        var lines = data.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        return lines
            .Skip(1) // skip header
            .Select(line =>
            {
                var parts = line.Split(',');
                return new Person(parts[0], int.Parse(parts[1]), parts[2]);
            })
            .ToList();
    }
}
