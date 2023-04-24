using TemplateMethod.AbstractClasses;
using TemplateMethod.Models;

namespace TemplateMethod.ConcreteClasses;

public class SkyBankInterestAccrualsCalculator : InterestAccrualsCalculator
{
    protected override decimal CalculateInterestAccruals(Account account, double interest)
    {
        // custom calculation for SkyBank
        return (decimal) interest * account.Balance * 0.05m;
    }

    protected override double GetInterestRate(Account account)
    {
        // custom interest rate calculation for SkyBank
        return account.Balance switch
        {
            < 10000 => 0.01,
            < 20000 => 0.02,
            _ => 0.03
        };
    }
}