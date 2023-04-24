namespace AbstractFactory.Products;

public class PlatinumDebitCard : DebitCard
{
    protected override decimal CashbackPercentage { get; } = 0.15m;
    protected override decimal AnnualFee { get; } = 300m;
}