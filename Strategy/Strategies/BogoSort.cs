// This implementation was taken form https://rosettacode.org/

namespace Strategy.Strategies;

public class BogoSort : ISortAlgorithm
{
    public void Sort<T>(IList<T> list) where T : IComparable
    {
        Sort(list.ToList());
    }

    private static void Sort<T>(List<T> list) where T : IComparable
    {
        while (!IsSorted(list)) Shuffle(list);
    }

    private static bool IsSorted<T>(IList<T> list) where T : IComparable
    {
        if (list.Count <= 1)
            return true;
        for (var i = 1; i < list.Count; i++)
            if (list[i].CompareTo(list[i - 1]) < 0)
                return false;
        return true;
    }

    private static void Shuffle<T>(IList<T> list)
    {
        var rand = new Random();
        for (var i = 0; i < list.Count; i++)
        {
            var swapIndex = rand.Next(list.Count);
            (list[swapIndex], list[i]) = (list[i], list[swapIndex]);
        }
    }
}