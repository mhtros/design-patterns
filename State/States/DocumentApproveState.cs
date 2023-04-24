using State.Contexts;
using State.Models;

namespace State.States;

public class DocumentApproveState : DocumentState
{
    public override DocumentStatus Status => DocumentStatus.Approved;

    public override void Modify(Action action, Document document)
    {
        action.Invoke();
        document.ChangeState(new DocumentDraftState());
    }

    public override void Publish(Document document)
    {
        // Upload document on the web server
        document.ChangeState(new DocumentPublishState());
    }
}