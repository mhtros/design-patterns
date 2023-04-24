namespace Memento;

public class Statistics
{
    public Statistics(int health, int attack, int defence)
    {
        Health = health;
        Attack = attack;
        Defence = defence;
    }

    public int Health { get; set; }
    public int Attack { get; set; }
    public int Defence { get; set; }
}