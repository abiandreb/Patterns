namespace CommandPattern.SmartHome;

public class LightOffCommand(Light light) : ICommand
{
    public string Name => "Light Off";

    public void Execute() => light.Off();
    public void Undo() => light.On();
}
