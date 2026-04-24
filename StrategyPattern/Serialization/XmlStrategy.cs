using System.Xml.Serialization;

namespace StrategyPattern.Serialization;

public class XmlStrategy : ISerializationStrategy
{
    private static readonly XmlSerializer Serializer = new(typeof(List<PersonXmlDto>),
        new XmlRootAttribute("People"));

    public string Serialize(List<Person> people)
    {
        var dtos = people.Select(p => new PersonXmlDto { Name = p.Name, Age = p.Age, City = p.City }).ToList();
        using var writer = new StringWriter();
        Serializer.Serialize(writer, dtos);
        return writer.ToString();
    }

    public List<Person> Deserialize(string data)
    {
        using var reader = new StringReader(data);
        var dtos = (List<PersonXmlDto>?)Serializer.Deserialize(reader) ?? [];
        return dtos.Select(d => new Person(d.Name, d.Age, d.City)).ToList();
    }
}

public class PersonXmlDto
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public string City { get; set; } = "";
}
