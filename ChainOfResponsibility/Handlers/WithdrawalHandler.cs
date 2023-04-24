using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers;

public class WithdrawalHandler : AccountHandler
{
    public override void Handle(AccountRequest request)
    {
        if (request.RequestType == (int) AccountRequestType.Withdrawal)
        {
            var account = Database.Accounts.FirstOrDefault(x => x.AccountNumber == request.ReceiverAccountNumber);

            if (account == null)
                throw new ArgumentException($"No account with account No:${request.ReceiverAccountNumber} was found.");

            if (account.Balance < request.Amount) throw new ApplicationException("No sufficient amount");

            account.Balance -= request.Amount;
        }

        else
        {
            NextHandler?.Handle(request);
        }
    }
}