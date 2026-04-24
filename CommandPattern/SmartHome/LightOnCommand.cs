namespace CommandPattern.SmartHome;

public class LightOnCommand(Light light) : ICommand
{
    public string Name => "Light On";

    public void Execute() => light.On();
    public void Undo() => light.Off();
}
