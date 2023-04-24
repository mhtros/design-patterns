// This implementation was taken form https://rosettacode.org/

namespace Strategy.Strategies;

public class HeapSort : ISortAlgorithm
{
    public void Sort<T>(IList<T> list) where T : IComparable
    {
        Sort(list.ToArray(), 0, list.Count, Comparer<T>.Default);
    }

    private static void Sort<T>(IList<T> array, int offset, int length, IComparer<T> comparer) where T : IComparable
    {
        Sort(array, offset, length, comparer.Compare);
    }

    private static void Sort<T>(IList<T> array, int offset, int length, Comparison<T> comparison) where T : IComparable
    {
        // build binary heap from all items
        for (var i = 0; i < length; i++)
        {
            var index = i;
            var item = array[offset + i]; // use next item

            // and move it on top, if greater than parent
            while (index > 0 &&
                   comparison(array[offset + (index - 1) / 2], item) < 0)
            {
                var top = (index - 1) / 2;
                array[offset + index] = array[offset + top];
                index = top;
            }

            array[offset + index] = item;
        }

        for (var i = length - 1; i > 0; i--)
        {
            // delete max and place it as last
            var last = array[offset + i];
            array[offset + i] = array[offset];

            var index = 0;
            // the last one positioned in the heap
            while (index * 2 + 1 < i)
            {
                int left = index * 2 + 1, right = left + 1;

                if (right < i && comparison(array[offset + left], array[offset + right]) < 0)
                {
                    if (comparison(last, array[offset + right]) > 0) break;

                    array[offset + index] = array[offset + right];
                    index = right;
                }
                else
                {
                    if (comparison(last, array[offset + left]) > 0) break;

                    array[offset + index] = array[offset + left];
                    index = left;
                }
            }

            array[offset + index] = last;
        }
    }
}