namespace AbstractFactory.Products;

public class PlatinumCreditCard : CreditCard
{
    protected override decimal CreditLimit { get; } = 10000m;
}