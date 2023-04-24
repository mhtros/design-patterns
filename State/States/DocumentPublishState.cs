using State.Contexts;
using State.Models;

namespace State.States;

public class DocumentPublishState : DocumentState
{
    public override DocumentStatus Status => DocumentStatus.Published;

    private static void NotAllowedAction(string action)
    {
        Console.WriteLine($" error: {action}: DOCUMENT IS PUBLISHED... NO FURTHER ACTIONS ARE ALLOWED.");
    }

    public override void Modify(Action action, Document document)
    {
        NotAllowedAction(nameof(Modify));
    }

    public override void Review(Document document)
    {
        NotAllowedAction(nameof(Review));
    }

    public override void ReadyForReview(Document document)
    {
        NotAllowedAction(nameof(ReadyForReview));
    }

    public override void BypassReview(Document document)
    {
        NotAllowedAction(nameof(BypassReview));
    }

    public override void Publish(Document document)
    {
        NotAllowedAction(nameof(Publish));
    }
}