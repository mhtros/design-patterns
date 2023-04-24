using Command.Receivers;

namespace Command.Commands;

public class DepositCommand : ICommand
{
    private readonly decimal _amount;
    private readonly BankAccount _bankAccount;

    public DepositCommand(BankAccount bankAccount, decimal amount)
    {
        _bankAccount = bankAccount;
        _amount = amount;
    }

    public void Execute()
    {
        _bankAccount.Deposit(_amount);
    }

    public void Undo()
    {
        _bankAccount.Withdraw(_amount);
    }
}