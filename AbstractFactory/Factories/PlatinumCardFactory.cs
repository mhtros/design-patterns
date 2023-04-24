using AbstractFactory.Products;

namespace AbstractFactory.Factories;

public class PlatinumCardFactory : ICardFactory
{
    public CreditCard CreateCreditCard()
    {
        return new PlatinumCreditCard();
    }

    public DebitCard CreateDebitCard()
    {
        return new PlatinumDebitCard();
    }
}