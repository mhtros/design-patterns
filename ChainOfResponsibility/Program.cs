using ChainOfResponsibility.Commons;
using ChainOfResponsibility.Handlers;
using ChainOfResponsibility.Models;

var handler1 = new DepositHandler();
var handler2 = new WithdrawalHandler();
var handler3 = new TransferHandler();

handler1.Next(handler2);
handler2.Next(handler3);

// The Deposit handler will handle the request and the chain will terminate.
var request1 = new AccountRequest
{
    RequestType = (int) AccountRequestType.Deposit,
    ReceiverAccountNumber = "4111111117444490",
    Amount = 150
};

handler1.Handle(request1);
Console.WriteLine(Audit.AccountsAudits());
Console.WriteLine("---");

// The deposit handler will pass the request to withdrawal and the withdrawal to transfer.
var request2 = new AccountRequest
{
    RequestType = (int) AccountRequestType.Transfer,
    ReceiverAccountNumber = "4041370000456459",
    SenderAccountNumber = "4111111117444490",
    Amount = 50
};

handler1.Handle(request2);
Console.WriteLine(Audit.AccountsAudits());
Console.WriteLine("---");

// The deposit handler will pass the request to withdrawal and the
// withdrawal will handle the request and the chain will terminate.
var request3 = new AccountRequest
{
    RequestType = (int) AccountRequestType.Withdrawal,
    ReceiverAccountNumber = "4041370000456459",
    Amount = 50
};

handler1.Handle(request3);
Console.WriteLine(Audit.AccountsAudits());