namespace Algorithms.Algorithms.Sort;

/// <summary>
/// Check first and second elements
/// If first element > second element swap this and go next
/// If array to be end, decrement checked array to 1
/// </summary>
public class BubbleSort : ISortable
{
    public int[] Sort(int[] array)
    {
        int buffer;
        int endArrayStrafe = 1;
        for (int i = 0; i < array.Length - endArrayStrafe; i++)
        {
            if (array[i] > array[i + 1])
            {
                buffer = array[i];
                array[i] = array[i + 1];
                array[i + 1] = buffer;
            }

            if (i + 1 == array.Length - endArrayStrafe)
            {
                i = -1;
                endArrayStrafe++;
            }
        }

        return array;
    }
}