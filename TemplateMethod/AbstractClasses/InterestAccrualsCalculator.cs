using TemplateMethod.Models;

namespace TemplateMethod.AbstractClasses;

public abstract class InterestAccrualsCalculator
{
    //Template Method
    public void AddInterestAccruals(Guid accountId)
    {
        var account = GetAccountById(accountId);

        if (account is null) throw new ApplicationException($"No Account with id = {accountId} was found!");

        var interestRate = GetInterestRate(account);
        var interestAmount = CalculateInterestAccruals(account, interestRate);

        Console.WriteLine($"   Balance BEFORE interest rate was added: {account.Balance:N}");
        account.Balance += interestAmount;
        Console.WriteLine($"   Balance AFTER interest rate was added: {account.Balance:N}");
    }

    protected virtual Account GetAccountById(Guid id)
    {
        return new Account(10000, new Guid("44c02f0e-908d-4eea-877f-906d7a959b5e"));
    }

    protected abstract double GetInterestRate(Account account);

    protected abstract decimal CalculateInterestAccruals(Account account, double interest);
}