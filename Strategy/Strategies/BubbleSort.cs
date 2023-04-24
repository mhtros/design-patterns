// This implementation was taken form https://rosettacode.org/

namespace Strategy.Strategies;

public class BubbleSort : ISortAlgorithm
{
    public void Sort<T>(IList<T> list) where T : IComparable
    {
        bool madeChanges;
        var itemCount = list.Count;

        do
        {
            madeChanges = false;
            itemCount--;

            for (var i = 0; i < itemCount; i++)
            {
                if (list[i].CompareTo(list[i + 1]) <= 0) continue;

                (list[i + 1], list[i]) = (list[i], list[i + 1]);
                madeChanges = true;
            }
        } while (madeChanges);
    }
}