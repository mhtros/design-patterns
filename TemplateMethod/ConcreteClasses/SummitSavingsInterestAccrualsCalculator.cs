using TemplateMethod.AbstractClasses;
using TemplateMethod.Models;

namespace TemplateMethod.ConcreteClasses;

public class SummitSavingsInterestAccrualsCalculator : InterestAccrualsCalculator
{
    protected override decimal CalculateInterestAccruals(Account account, double interest)
    {
        // custom calculation for SummitSavings
        return (decimal) interest * account.Balance * 0.03m;
    }

    protected override double GetInterestRate(Account account)
    {
        // custom interest rate calculation for SummitSavings
        return account.Balance switch
        {
            < 10000 => 0.015,
            < 20000 => 0.025,
            _ => 0.035
        };
    }
}