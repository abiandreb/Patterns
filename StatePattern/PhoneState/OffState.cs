namespace StatePattern.PhoneState;

public class OffState(Phone phone) : IPhoneState
{
    public void PressPowerButton() => phone.SetState(new LockedState(phone));

    public void PressHomeButton() => Console.WriteLine("    (nothing happens)");

    public void Swipe() => Console.WriteLine("    (nothing happens)");
}
