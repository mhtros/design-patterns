using Command.Commands;
using Command.Invokers;
using Command.Receivers;

var bankAccount = new BankAccount(1000);

var command1 = new WithdrawCommand(bankAccount, 100);
var command2 = new DepositCommand(bankAccount, 500);
var command3 = new WithdrawCommand(bankAccount, 200);

var balanceManager = new BalanceManager();

balanceManager.ExecuteCommand(command1); // 900
balanceManager.ExecuteCommand(command2); // 1400
balanceManager.ExecuteCommand(command3); // 1200

balanceManager.UndoLast(); // 1400
balanceManager.UndoLast(); // 900
balanceManager.UndoLast(); // 1000