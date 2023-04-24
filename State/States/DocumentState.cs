using State.Contexts;
using State.Models;

namespace State.States;

public abstract class DocumentState : IDocumentState
{
    public abstract DocumentStatus Status { get; }

    public virtual void Modify(Action action, Document document)
    {
        NotAllowedAction(nameof(Modify));
    }

    public virtual void ReadyForReview(Document document)
    {
        NotAllowedAction(nameof(ReadyForReview));
    }

    public virtual void BypassReview(Document document)
    {
        NotAllowedAction(nameof(BypassReview));
    }

    public virtual void Review(Document document)
    {
        NotAllowedAction(nameof(Review));
    }

    public virtual void Publish(Document document)
    {
        NotAllowedAction(nameof(Publish));
    }

    private void NotAllowedAction(string action)
    {
        Console.WriteLine($" error: {action} NOT ALLOWED ON STATUS {Status}.");
    }
}