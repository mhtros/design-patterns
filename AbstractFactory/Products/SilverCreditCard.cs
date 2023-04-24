namespace AbstractFactory.Products;

public class SilverCreditCard : CreditCard
{
    protected override decimal CreditLimit { get; } = 1000m;
}