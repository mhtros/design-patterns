using Observer.Models;

namespace Observer.Subscribers;

public class ExpensiveBuyer : MobileBuyer
{
    public override void OnNext(Mobile mobile)
    {
        if (mobile.Price < 900)
        {
            Console.WriteLine($"{nameof(ExpensiveBuyer)}: Im only interesting on expensive mobiles.");
            return;
        }

        Console.WriteLine($"{nameof(ExpensiveBuyer)}: Ok! I want to buy {mobile.Model} for {mobile.Price:N}.");
    }
}