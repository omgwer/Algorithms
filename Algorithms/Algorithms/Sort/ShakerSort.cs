using Algorithms.Utils;

namespace Algorithms.Algorithms.Sort;

/// <summary>
/// The first rightward pass will shift the largest element to its correct place at the end,
/// and the following leftward pass will shift the smallest element to its correct place at
/// the beginning. The second complete pass will shift the second largest and second smallest
/// elements to their correct places, and so on. After i passes, the first i and the last i
/// elements in the list are in their correct positions, and do not need to be checked.
/// By shortening the part of the list that is sorted each time, the number of operations can be halved
/// </summary>
public class ShakerSort : ISortable
{
    public int[] Sort(int[] array)
    {
        array.Print();
        int endArrayStrafe = 1;
        int startArrayStrafe = 1;
        for (int i = 0; i < array.Length - endArrayStrafe; i++)
        {
            if (array[i] > array[i + 1])
            {
                ArrayExtensions.Swap(i, i+1, array);
            }

            if (i + 1 == array.Length - endArrayStrafe)
            {
                for (int j = i; j > startArrayStrafe; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        ArrayExtensions.Swap(j, j-1, array);
                    }
                }
                i = -1;
                endArrayStrafe++;
                startArrayStrafe++;
            }
        }

        return array;
    }
}