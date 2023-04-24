using Flyweight.Flyweights;

namespace Flyweight.Contexts;

public class Customer
{
    private PricingPlan _plan;

    public Customer(PricingPlan plan)
    {
        _plan = plan;
    }

    public decimal DataConsumption { get; set; }
    public decimal CallMinutes { get; set; }
    public int TextNumber { get; set; }

    public void ChangePricingPlan(PricingPlan plan)
    {
        _plan = plan;
    }

    public decimal CalculateDataCost()
    {
        return _plan.DataCharge * DataConsumption;
    }

    public decimal CalculateCallCost()
    {
        return _plan.CallCharge * CallMinutes;
    }

    public decimal CalculateTextCost()
    {
        return _plan.TextCharge * TextNumber;
    }

    public decimal CalculateTotalCost()
    {
        return CalculateDataCost() + CalculateCallCost() + CalculateTextCost();
    }
}