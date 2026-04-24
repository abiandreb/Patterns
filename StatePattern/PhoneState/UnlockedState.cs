namespace StatePattern.PhoneState;

public class UnlockedState(Phone phone) : IPhoneState
{
    public void PressPowerButton() => phone.SetState(new LockedState(phone));

    public void PressHomeButton() => Console.WriteLine("    Going to home screen");

    public void Swipe() => Console.WriteLine("    Switching to next app");
}
