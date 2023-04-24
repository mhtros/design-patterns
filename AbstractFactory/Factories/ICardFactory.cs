using AbstractFactory.Products;

namespace AbstractFactory.Factories;

public interface ICardFactory
{
    public CreditCard CreateCreditCard();

    public DebitCard CreateDebitCard();
}