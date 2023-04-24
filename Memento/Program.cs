using Memento;
using Memento.Caretakers;
using Memento.Originators;

var orc = new Character("Magus", Archetype.Fighter, new Statistics(100, 200, 100));
Console.WriteLine(orc);

var orcCustomizer = new CharacterCustomizer(orc);

orcCustomizer.Customize(character =>
{
    character.Statistics.Health = 50;
    character.Statistics.Attack = 500;
    character.Statistics.Defence = 10;
});

orcCustomizer.SaveCharacterState();
Console.WriteLine(orc);

orcCustomizer.Customize(character => { character.Archetype = Archetype.Assassin; });
Console.WriteLine(orc);

orcCustomizer.UndoLastState();
Console.WriteLine(orc);

orcCustomizer.UndoLastState();
Console.WriteLine(orc);

orcCustomizer.UndoLastState();
Console.WriteLine(orc);