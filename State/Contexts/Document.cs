using System.Text;
using State.Models;
using State.States;

namespace State.Contexts;

public class Document
{
    private IDocumentState _state;

    public Document(string title, string body, IDocumentState state, Author author)
    {
        if (state.Status != DocumentStatus.Draft)
            throw new ArgumentException($"Initial state must be on status '{DocumentStatus.Draft}'");

        Title = title;
        Body = body;
        Author = author;
        _state = state;
    }

    public DocumentStatus Status => _state.Status;
    public Author Author { get; }
    private string Title { get; set; }
    private string Body { get; set; }

    public void ChangeState(IDocumentState state)
    {
        Console.WriteLine($" msg: {_state.Status} -> {state.Status}");
        _state = state;
    }

    public void Modify(string title, string body)
    {
        _state.Modify(() =>
        {
            Title = title;
            Body = body;
        }, this);
    }

    public void Review()
    {
        _state.Review(this);
    }

    public void ReadyForReview()
    {
        _state.ReadyForReview(this);
    }

    public void BypassReview()
    {
        _state.BypassReview(this);
    }

    public void Publish()
    {
        _state.Publish(this);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($" ~~ {Title.ToUpper()} - (Written by {Author.Name}):");
        sb.AppendLine(Body);

        return sb.ToString();
    }
}