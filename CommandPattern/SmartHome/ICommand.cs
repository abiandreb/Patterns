namespace CommandPattern.SmartHome;

public interface ICommand
{
    string Name { get; }
    void Execute();
    void Undo();
}
