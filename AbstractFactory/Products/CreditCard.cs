using System.Text;

namespace AbstractFactory.Products;

public abstract class CreditCard
{
    protected abstract decimal CreditLimit { get; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine("CREDIT CARD");
        sb.AppendLine($" Credit Limit: {CreditLimit:N}");

        return sb.ToString();
    }
}