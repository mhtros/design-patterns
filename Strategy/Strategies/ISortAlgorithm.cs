namespace Strategy.Strategies;

public interface ISortAlgorithm
{
    public void Sort<T>(IList<T> list) where T : IComparable;
}