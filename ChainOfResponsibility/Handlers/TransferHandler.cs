using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers;

public class TransferHandler : AccountHandler
{
    public override void Handle(AccountRequest request)
    {
        if (request.RequestType == (int) AccountRequestType.Transfer)
        {
            var receiver = Database.Accounts.FirstOrDefault(x => x.AccountNumber == request.ReceiverAccountNumber);

            if (receiver == null)
                throw new ArgumentException($"No account with account No:${request.ReceiverAccountNumber} was found.");

            var sender = Database.Accounts.FirstOrDefault(x => x.AccountNumber == request.SenderAccountNumber);

            if (sender == null)
                throw new ArgumentException($"No account with account No:${request.ReceiverAccountNumber} was found.");

            if (sender.Balance < request.Amount) throw new ApplicationException("No sufficient amount");

            sender.Balance -= request.Amount;
            receiver.Balance += request.Amount;
        }

        else
        {
            NextHandler?.Handle(request);
        }
    }
}