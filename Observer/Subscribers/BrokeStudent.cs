using Observer.Models;

namespace Observer.Subscribers;

public class BrokeStudent : MobileBuyer
{
    public override void OnNext(Mobile mobile)
    {
        if (mobile.Price > 150)
        {
            Console.WriteLine(
                $"{nameof(BrokeStudent)}: Too poor to afford {mobile.Manufacturer}'s {mobile.Model} for {mobile.Price:N}.");
            return;
        }

        Console.WriteLine($"{nameof(BrokeStudent)}: I'll settle for {mobile.Model} for {mobile.Price:N}.");
    }
}