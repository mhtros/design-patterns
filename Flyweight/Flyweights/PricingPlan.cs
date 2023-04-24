namespace Flyweight.Flyweights;

public class PricingPlan
{
    public PricingPlan(decimal dataCharge, decimal callCharge, decimal textCharge)
    {
        DataCharge = dataCharge;
        CallCharge = callCharge;
        TextCharge = textCharge;
    }

    public decimal DataCharge { get; }
    public decimal CallCharge { get; }
    public decimal TextCharge { get; }
}