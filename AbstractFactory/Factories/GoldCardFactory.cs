using AbstractFactory.Products;

namespace AbstractFactory.Factories;

public class GoldCardFactory : ICardFactory
{
    public CreditCard CreateCreditCard()
    {
        return new GoldCreditCard();
    }

    public DebitCard CreateDebitCard()
    {
        return new GoldDebitCard();
    }
}