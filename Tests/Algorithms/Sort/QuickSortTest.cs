using Algorithms.Algorithms.Sort;

namespace Tests.Algorithms.Sort;

public class QuickSortTest() : BaseSortTest(QuickSort)
{
    private static readonly ISortable QuickSort = new QuickSort();
}