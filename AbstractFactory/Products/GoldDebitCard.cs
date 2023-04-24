namespace AbstractFactory.Products;

public class GoldDebitCard : DebitCard
{
    protected override decimal CashbackPercentage { get; } = 0.10m;
    protected override decimal AnnualFee { get; } = 200m;
}