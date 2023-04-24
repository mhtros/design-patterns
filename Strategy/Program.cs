using Strategy;
using Strategy.Contexts;
using Strategy.Strategies;

var sortingAlgorithms = new Dictionary<string, ISortAlgorithm>
{
    {nameof(BubbleSort), new BubbleSort()},
    {nameof(MergeSort), new MergeSort()},
    {nameof(HeapSort), new HeapSort()}
    //{nameof(BogoSort), new BogoSort()} // Uncomment at your own risk!
};

var timeTracker = new SortingTimeTracker<int>(MockData.RandomNumbers);

foreach (var keyValuePair in sortingAlgorithms)
{
    timeTracker.SortingAlgorithm = keyValuePair.Value;
    var result = timeTracker.TrackExecutionTime();
    Console.WriteLine($"{keyValuePair.Key}\t:{result}");
}