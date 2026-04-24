namespace StatePattern.PhoneState;

public class LockedState(Phone phone) : IPhoneState
{
    public void PressPowerButton() => phone.SetState(new OffState(phone));

    public void PressHomeButton() => Console.WriteLine("    Showing lock-screen info: 12:00 | 3 notifications");

    public void Swipe() => phone.SetState(new UnlockedState(phone));
}
