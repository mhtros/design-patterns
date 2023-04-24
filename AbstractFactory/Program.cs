using AbstractFactory;
using AbstractFactory.Factories;

var type = GetCardType();

ICardFactory factory = type switch
{
    (int) CardType.Silver => new SilverCardFactory(),
    (int) CardType.Gold => new GoldCardFactory(),
    (int) CardType.Platinum => new PlatinumCardFactory(),
    _ => throw new Exception("Invalid card type.")
};

var pairGenerator = new CardPairGenerator(factory);
var (creditCard, debitCard) = pairGenerator.CreatePair();

Console.WriteLine(creditCard);
Console.WriteLine(debitCard);

// Complicate logic to chose a card type
int GetCardType()
{
    return new Random().Next(0, 3);
}