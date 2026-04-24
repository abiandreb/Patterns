namespace StatePattern.PhoneState;

public class Phone
{
    public IPhoneState State { get; private set; }

    public Phone()
    {
        State = new OffState(this);
    }

    public void SetState(IPhoneState state)
    {
        State = state;
        Console.WriteLine($"  [State → {state.GetType().Name.Replace("State", "")}]");
    }

    public void PressPowerButton()
    {
        Console.WriteLine("  > Press Power Button");
        State.PressPowerButton();
    }

    public void PressHomeButton()
    {
        Console.WriteLine("  > Press Home Button");
        State.PressHomeButton();
    }

    public void Swipe()
    {
        Console.WriteLine("  > Swipe");
        State.Swipe();
    }
}
