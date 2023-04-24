using System.Text;

namespace AbstractFactory.Products;

public abstract class DebitCard
{
    protected abstract decimal CashbackPercentage { get; }
    protected abstract decimal AnnualFee { get; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine("DEBIT CARD");
        sb.AppendLine($" Annual Fee: {AnnualFee:N}");
        sb.AppendLine($" Cashback Percentage: {CashbackPercentage:N}");

        return sb.ToString();
    }
}