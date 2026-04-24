namespace StatePattern.PhoneState;

public interface IPhoneState
{
    void PressPowerButton();
    void PressHomeButton();
    void Swipe();
}
