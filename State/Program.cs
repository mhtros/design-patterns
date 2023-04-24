using State.Contexts;
using State.Models;
using State.States;

const string darkOrcs = " ~~ The campaign of the dark orcs left the kingdom of Teleria in ruins,\n" +
                        " ~~ as their brutal tactics and ruthless chieftain proved to be too much for\n" +
                        " ~~ the king's armies to handle.";

var initState1 = new DocumentDraftState();
var admin = new Author("Kilt Noe", AuthorRole.Administrator);
var document1 = new Document("The campaign of the dark orcs", darkOrcs, initState1, admin);

const string cosmicAbyss = " ~~ The cosmic abyss is a mysterious and dangerous void in the universe\n" +
                           " ~~ that has puzzled ethereal explorers for generations.";

var initState2 = new DocumentDraftState();
var writer = new Author("Croft Elva", AuthorRole.Writer);
var document2 = new Document("Cosmic Abyss", cosmicAbyss, initState2, writer);

// DOCUMENT 1
Console.WriteLine("DOCUMENT 1");
document1.Modify("The dark orcs campaign", darkOrcs);
Console.WriteLine(document1);
document1.Review();
document1.BypassReview();
document1.Modify("The campaign of the dark orcs", darkOrcs);
document1.BypassReview();
document1.Publish();

// DOCUMENT 2
Console.WriteLine("DOCUMENT 2");
document2.BypassReview();
Console.WriteLine(document2);
document2.ReadyForReview();

while (document2.Status != DocumentStatus.Approved)
{
    document2.Review();
    if (document2.Status == DocumentStatus.Rejected)
    {
        document2.Modify("Cosmic Abyss", cosmicAbyss);
        document2.ReadyForReview();
    }
}

document2.Publish();
document2.Review();