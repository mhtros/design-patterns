using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers;

public class DepositHandler : AccountHandler
{
    public override void Handle(AccountRequest request)
    {
        if (request.RequestType == (int) AccountRequestType.Deposit)
        {
            var account = Database.Accounts.FirstOrDefault(x => x.AccountNumber == request.ReceiverAccountNumber);

            if (account == null)
                throw new ArgumentException($"No account with account No:${request.ReceiverAccountNumber} was found.");

            account.Balance += request.Amount;
        }

        else
        {
            NextHandler?.Handle(request);
        }
    }
}