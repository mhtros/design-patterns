namespace AbstractFactory.Products;

public class GoldCreditCard : CreditCard
{
    protected override decimal CreditLimit { get; } = 5000m;
}