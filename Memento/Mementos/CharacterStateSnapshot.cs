namespace Memento.Mementos;

public class CharacterStateSnapshot : StateSnapshot
{
    public CharacterStateSnapshot(string name, Archetype archetype, Statistics statistics)
    {
        Name = name;
        Archetype = archetype;
        Statistics = statistics;
    }

    public string Name { get; }
    public Archetype Archetype { get; }
    public Statistics Statistics { get; }
}