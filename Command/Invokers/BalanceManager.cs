using Command.Commands;

namespace Command.Invokers;

public class BalanceManager
{
    private readonly Stack<ICommand> _commandHistory = new();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        _commandHistory.Push(command);
    }

    public void UndoLast()
    {
        var lastCommand = _commandHistory.Pop();
        lastCommand.Undo();
    }
}