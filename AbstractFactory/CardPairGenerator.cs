using AbstractFactory.Factories;
using AbstractFactory.Products;

namespace AbstractFactory;

public class CardPairGenerator
{
    private readonly ICardFactory _factory;

    public CardPairGenerator(ICardFactory factory)
    {
        _factory = factory;
    }

    public (CreditCard, DebitCard) CreatePair()
    {
        var credit = _factory.CreateCreditCard();
        var debit = _factory.CreateDebitCard();

        return (credit, debit);
    }
}