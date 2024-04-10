namespace Algorithms.Algorithms.Sort;

public class StupidSort : ISortable
{
    public int[] Sort(int[] array)
    {
        int buffer;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                buffer = array[i];
                array[i] = array[i + 1];
                array[i + 1] = buffer;
                i = -1;
            }
        }
        return array;
    }
}