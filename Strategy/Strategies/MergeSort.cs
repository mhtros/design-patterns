// This implementation was taken form https://rosettacode.org/

namespace Strategy.Strategies;

public class MergeSort : ISortAlgorithm
{
    #region Math Methods

    private static int Ceiling(int numerator, int denominator)
    {
        return (numerator + denominator - 1) / denominator;
    }

    #endregion

    #region Insertion Sort

    private static class InsertionSort
    {
        public static void Sort<T>(IList<T> entries, int first, int last) where T : IComparable
        {
            for (var next = first + 1; next <= last; next++)
                Insert(entries, first, next);
        }

        /// <summary>Bubble next entry up to its sorted location, assuming entries[first:next - 1] are already sorted.</summary>
        private static void Insert<T>(IList<T> entries, int first, int next) where T : IComparable
        {
            var entry = entries[next];
            while (next > first && entries[next - 1].CompareTo(entry) > 0)
                entries[next] = entries[--next];
            entries[next] = entry;
        }
    }

    #endregion

    #region Constants

    private const uint InsertionLimitDefault = 12;
    private const int MergesDefault = 6;

    #endregion

    #region Properties

    private uint InsertionLimit { get; }
    private uint[]? Positions { get; init; }

    private readonly int _merges;

    public int Merges
    {
        get => _merges;
        init
        {
            // A minimum of 2 merges are required
            if (value > 1)
                _merges = value;
            else
                throw new ArgumentOutOfRangeException($"value = {value} must be greater than one", nameof(Merges));

            if (Positions != null && Positions.Length != _merges)
                Positions = new uint[_merges];
        }
    }

    #endregion

    #region Constructors

    private MergeSort(uint insertionLimit, int merges)
    {
        InsertionLimit = insertionLimit;
        Merges = merges;
    }

    public MergeSort()
        : this(InsertionLimitDefault, MergesDefault)
    {
    }

    #endregion

    #region Sort Methods

    public void Sort<T>(IList<T> entries) where T : IComparable
    {
        // Allocate merge buffer
        var entries2 = new T[entries.Count];
        Sort(entries, entries2, 0, entries.Count - 1);
    }

    // Top-Down K-way Merge Sort
    private void Sort<T>(IList<T> entries1, T[] entries2, int first, int last) where T : IComparable
    {
        var length = last + 1 - first;
        if (length < 2) return;

        if (length < Merges || length < InsertionLimit)
        {
            InsertionSort.Sort(entries1, first, last);
            return;
        }

        var left = first;
        var size = Ceiling(length, Merges);
        for (var remaining = length; remaining > 0; remaining -= size, left += size)
        {
            var right = left + Math.Min(remaining, size) - 1;
            Sort(entries1, entries2, left, right);
        }

        Merge(entries1, entries2, first, last);
        Array.Copy(entries2, first, entries1.ToArray(), first, length);
    }

    #endregion

    #region Merge Methods

    private void Merge<T>(IList<T> entries1, IList<T> entries2, int first, int last) where T : IComparable
    {
        if (Positions != null) Array.Clear(Positions, 0, Merges);
        // This implementation has a quadratic time dependency on the number of merges
        for (var index = first; index <= last; index++)
            entries2[index] = Remove(entries1, first, last);
    }

    private T Remove<T>(IList<T> entries, int first, int last) where T : IComparable
    {
        T entry = default!;
        int? found = default;
        var length = last + 1 - first;

        var index = 0;
        var left = first;
        var size = Ceiling(length, Merges);

        for (var remaining = length; remaining > 0; remaining -= size, left += size, index++)
        {
            if (Positions == null) continue;

            var position = Positions[index];
            if (position >= Math.Min(remaining, size)) continue;

            var next = entries[(int) (left + position)];
            if (found.HasValue && entry.CompareTo(next) <= 0) continue;

            found = index;
            entry = next;
        }

        // Remove entry
        if (found == null) return entry;
        if (Positions != null) Positions[found.Value]++;
        return entry;
    }

    #endregion
}