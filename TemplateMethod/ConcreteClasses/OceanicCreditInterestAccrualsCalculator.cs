using TemplateMethod.AbstractClasses;
using TemplateMethod.Models;

namespace TemplateMethod.ConcreteClasses;

public class OceanicCreditInterestAccrualsCalculator : InterestAccrualsCalculator
{
    protected override decimal CalculateInterestAccruals(Account account, double interest)
    {
        // custom calculation for OceanicCredit
        return (decimal) interest * account.Balance * 0.02m;
    }

    protected override double GetInterestRate(Account account)
    {
        // custom interest rate calculation for OceanicCredit
        return account.Balance switch
        {
            < 5000 => 0.005,
            < 10000 => 0.01,
            < 20000 => 0.015,
            _ => 0.02
        };
    }
}