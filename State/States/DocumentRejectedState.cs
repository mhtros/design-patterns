using State.Contexts;
using State.Models;

namespace State.States;

public class DocumentRejectedState : DocumentState
{
    public override DocumentStatus Status => DocumentStatus.Rejected;

    public override void Modify(Action action, Document document)
    {
        action.Invoke();
        document.ChangeState(new DocumentDraftState());
    }
}