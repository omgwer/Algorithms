using System.Text;

namespace Algorithms.Utils;

internal static class ArrayExtensions
{
    public static void Print(this int[] array)
    {
        StringBuilder stringBuilder = new();
        foreach (var i in array)
        {
            stringBuilder.Append($"{i} ");
        }
        Console.WriteLine(stringBuilder);
    }

    public static void Swap(int firstIndex, int secondIndex, int[] array)
    {
        if (firstIndex == secondIndex) return;
        if (firstIndex + 1 > array.Length && secondIndex + 1 > array.Length)
        {
            throw new ArgumentException("Out of array index");
        }
        (array[secondIndex], array[firstIndex]) = (array[firstIndex], array[secondIndex]);
    }
}