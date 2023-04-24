using State.Contexts;
using State.Models;

namespace State.States;

public class DocumentReviewState : DocumentState
{
    public override DocumentStatus Status => DocumentStatus.Review;

    public override void Review(Document document)
    {
        // Get admins response from review event raised by the draft state
        var passReview = new Random().NextDouble() >= 0.5;

        if (passReview) document.ChangeState(new DocumentApproveState());
        else document.ChangeState(new DocumentRejectedState());
    }
}