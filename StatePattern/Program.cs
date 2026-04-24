using StatePattern.PhoneState;

Console.WriteLine("=== State Pattern Demo ===\n");

var phone = new Phone();
Console.WriteLine($"Phone is {phone.State.GetType().Name.Replace("State", "")}\n");

// --- Turn on the phone ---
Console.WriteLine("1. Turn on the phone:");
phone.PressPowerButton();

// --- Try home button while locked ---
Console.WriteLine("\n2. Press Home while locked:");
phone.PressHomeButton();

// --- Unlock by swiping ---
Console.WriteLine("\n3. Swipe to unlock:");
phone.Swipe();

// --- Use the phone while unlocked ---
Console.WriteLine("\n4. Interact while unlocked:");
phone.PressHomeButton();
phone.Swipe();

// --- Lock the phone ---
Console.WriteLine("\n5. Lock with power button:");
phone.PressPowerButton();

// --- Turn off the phone ---
Console.WriteLine("\n6. Turn off the phone:");
phone.PressPowerButton();

// --- Try actions while off ---
Console.WriteLine("\n7. Try actions while off:");
phone.PressHomeButton();
phone.Swipe();

// =============================================
// Combination Lock example
// =============================================
Console.WriteLine("\n=== Combination Lock State ===\n");

// --- Correct combination ---
Console.WriteLine("1. Correct combination (1-2-3-4-5):");
var cl = new StatePattern.CombinationLock.CombinationLock([1, 2, 3, 4, 5]);
Console.WriteLine($"  Status: {cl.Status}");
cl.EnterDigit(1);
cl.EnterDigit(2);
cl.EnterDigit(3);
cl.EnterDigit(4);
cl.EnterDigit(5);

// --- Wrong combination ---
Console.WriteLine("\n2. Wrong combination (1-2-9-...):");
var cl2 = new StatePattern.CombinationLock.CombinationLock([1, 2, 3, 4, 5]);
Console.WriteLine($"  Status: {cl2.Status}");
cl2.EnterDigit(1);
cl2.EnterDigit(2);
cl2.EnterDigit(9);
