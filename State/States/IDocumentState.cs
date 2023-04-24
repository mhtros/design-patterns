using State.Contexts;
using State.Models;

namespace State.States;

public interface IDocumentState
{
    DocumentStatus Status { get; }

    public void Modify(Action action, Document document);
    public void ReadyForReview(Document document);
    public void BypassReview(Document document);
    public void Review(Document document);
    public void Publish(Document document);
}