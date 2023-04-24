using AbstractFactory.Products;

namespace AbstractFactory.Factories;

public class SilverCardFactory : ICardFactory
{
    public CreditCard CreateCreditCard()
    {
        return new SilverCreditCard();
    }

    public DebitCard CreateDebitCard()
    {
        return new SilverDebitCard();
    }
}