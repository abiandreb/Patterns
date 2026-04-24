namespace StrategyPattern.Serialization;

public interface ISerializationStrategy
{
    string Serialize(List<Person> people);
    List<Person> Deserialize(string data);
}
