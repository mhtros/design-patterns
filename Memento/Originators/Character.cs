using System.Text;
using Memento.Mementos;

namespace Memento.Originators;

public class Character : ISnapshot<CharacterStateSnapshot>
{
    public Character(string name, Archetype archetype, Statistics statistics)
    {
        Name = name;
        Archetype = archetype;
        Statistics = statistics;
    }

    public string Name { get; set; }

    public Archetype Archetype { get; set; }

    public Statistics Statistics { get; set; }

    public CharacterStateSnapshot CreateSnapshot()
    {
        // create a new instance of the Statistics class in order to prevent unwanted side effects.
        var statistics = new Statistics(Statistics.Health, Statistics.Attack, Statistics.Defence);
        return new CharacterStateSnapshot(Name, Archetype, statistics);
    }

    public void RestoreFromSnapshot(CharacterStateSnapshot stateSnapshot)
    {
        Name = stateSnapshot.Name;
        Archetype = stateSnapshot.Archetype;
        Statistics = stateSnapshot.Statistics;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"--- {Name} ---");
        sb.AppendLine($"{nameof(Archetype)}: {Archetype.ToString()}");
        sb.AppendLine("--- Stats ---");

        foreach (var propertyInfo in Statistics.GetType().GetProperties())
            sb.AppendLine($"{propertyInfo.Name}: {propertyInfo.GetValue(Statistics)}");

        return sb.ToString();
    }
}