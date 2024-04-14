namespace Algorithms.Algorithms.Sort;

/// <summary>
/// Check first and second elements
/// If first element > second element swap this element and go first array element
/// </summary>
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