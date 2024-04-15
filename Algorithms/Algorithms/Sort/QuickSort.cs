using Algorithms.Utils;

namespace Algorithms.Algorithms.Sort;

public class QuickSort : ISortable
{
    public int[] Sort(int[] array)
    {
        QuickSortAlgorithm(array, 0, array.Length - 1);
        return array;
    }

    private static void QuickSortAlgorithm(int[] array, int l, int r)
    {
        if (l < r)
        {
            int q = Partition(array, l, r);
            QuickSortAlgorithm(array, l, q);
            QuickSortAlgorithm(array, q + 1, r);
        }
    }

    private static int Partition(int[] array, int l, int r)
    {
        int delemiter = array[(l + r) / 2];
        int i = l;
        int j = r;
        while (i < j)
        {
            while (array[i] < delemiter)
            {
                i++;
            }

            while (array[j] > delemiter)
            {
                j--;
            }

            if (i >= j)
            {
                break;
            }

            ArrayExtensions.Swap(array[i++], array[j--], array);
        }

        return j;
    }
}