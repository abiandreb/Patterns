namespace StrategyPattern.Serialization;

public class BinaryStrategy : ISerializationStrategy
{
    public string Serialize(List<Person> people)
    {
        using var ms = new MemoryStream();
        using var writer = new BinaryWriter(ms);

        writer.Write(people.Count);
        foreach (var p in people)
        {
            writer.Write(p.Name);
            writer.Write(p.Age);
            writer.Write(p.City);
        }

        return Convert.ToBase64String(ms.ToArray());
    }

    public List<Person> Deserialize(string data)
    {
        var bytes = Convert.FromBase64String(data);
        using var ms = new MemoryStream(bytes);
        using var reader = new BinaryReader(ms);

        var count = reader.ReadInt32();
        var people = new List<Person>(count);
        for (var i = 0; i < count; i++)
        {
            var name = reader.ReadString();
            var age = reader.ReadInt32();
            var city = reader.ReadString();
            people.Add(new Person(name, age, city));
        }

        return people;
    }
}
