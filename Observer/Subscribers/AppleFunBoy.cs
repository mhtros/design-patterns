using Observer.Models;

namespace Observer.Subscribers;

public class AppleFunBoy : MobileBuyer
{
    public override void OnNext(Mobile mobile)
    {
        if (mobile.Manufacturer != Manufacturer.Apple)
        {
            Console.WriteLine($"{nameof(AppleFunBoy)}: Don't bother me with rubbish phones.");
            return;
        }

        Console.WriteLine($"{nameof(AppleFunBoy)}: Oh boi!!! sign me in!!!");
    }
}