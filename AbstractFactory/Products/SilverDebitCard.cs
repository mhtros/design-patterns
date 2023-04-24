namespace AbstractFactory.Products;

public class SilverDebitCard : DebitCard
{
    protected override decimal CashbackPercentage { get; } = 0.05m;
    protected override decimal AnnualFee { get; } = 50m;
}