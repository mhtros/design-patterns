using Strategy.Strategies;

namespace Strategy.Contexts;

public class SortingTimeTracker<T> : ExecutionTimeTracker where T : IComparable
{
    private readonly IList<T> _sortingData;

    public SortingTimeTracker(IList<T> sortingData, ISortAlgorithm? sortingAlgorithm = null)
    {
        _sortingData = sortingData;
        SortingAlgorithm = sortingAlgorithm;
    }

    public ISortAlgorithm? SortingAlgorithm { get; set; }

    public override string TrackExecutionTime()
    {
        if (SortingAlgorithm is null) throw new ArgumentNullException(nameof(SortingAlgorithm));
        var copiedList = new List<T>(_sortingData); // make a copy every time.
        var executionTime = TrackExecutionTime(() => SortingAlgorithm?.Sort(copiedList));
        return executionTime;
    }
}