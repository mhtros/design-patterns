using System.Data;
using Flyweight.Flyweights;

namespace Flyweight.Factories;

public class PricingPlanFactory
{
    private readonly Dictionary<string, PricingPlan> _cachedPlans = new();

    public void Add(string pricePlan, PricingPlan plan)
    {
        _cachedPlans.Add(pricePlan, plan);
    }

    public PricingPlan Get(string pricePlan)
    {
        if (!_cachedPlans.ContainsKey(pricePlan)) throw new DataException($"{pricePlan} is not defined.");

        return _cachedPlans[pricePlan];
    }
}