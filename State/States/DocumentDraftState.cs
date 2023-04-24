using State.Contexts;
using State.Models;

namespace State.States;

public class DocumentDraftState : DocumentState
{
    public override DocumentStatus Status => DocumentStatus.Draft;

    public override void Modify(Action action, Document document)
    {
        action.Invoke();
        document.ChangeState(new DocumentDraftState());
    }

    public override void ReadyForReview(Document document)
    {
        // Generate a event to notify administrators.
        document.ChangeState(new DocumentReviewState());
    }

    public override void BypassReview(Document document)
    {
        if (document.Author.Role != AuthorRole.Administrator)
        {
            Console.WriteLine($" error: {nameof(BypassReview)} FAILED. AUTHOR MUST BE ADMINISTRATOR.");
            return;
        }

        document.ChangeState(new DocumentApproveState());
    }
}