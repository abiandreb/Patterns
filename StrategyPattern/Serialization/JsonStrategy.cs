using System.Text.Json;

namespace StrategyPattern.Serialization;

public class JsonStrategy : ISerializationStrategy
{
    private static readonly JsonSerializerOptions Options = new() { WriteIndented = true };

    public string Serialize(List<Person> people) =>
        JsonSerializer.Serialize(people, Options);

    public List<Person> Deserialize(string data) =>
        JsonSerializer.Deserialize<List<Person>>(data) ?? [];
}
