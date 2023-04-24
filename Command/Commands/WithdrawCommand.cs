using Command.Receivers;

namespace Command.Commands;

public class WithdrawCommand : ICommand
{
    private readonly decimal _amount;
    private readonly BankAccount _bankAccount;

    public WithdrawCommand(BankAccount bankAccount, decimal amount)
    {
        _bankAccount = bankAccount;
        _amount = amount;
    }

    public void Execute()
    {
        _bankAccount.Withdraw(_amount);
    }

    public void Undo()
    {
        _bankAccount.Deposit(_amount);
    }
}