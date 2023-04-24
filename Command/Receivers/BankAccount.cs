namespace Command.Receivers;

public class BankAccount
{
    private decimal _balance;

    public BankAccount(decimal balance = default)
    {
        _balance = balance;
    }

    public override string ToString()
    {
        return $"{_balance:N}";
    }

    public void Deposit(decimal amount)
    {
        _balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > _balance) throw new ApplicationException("Insufficient amount");
        _balance -= amount;
    }
}