namespace Algorithms.Algorithms.Sort;

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