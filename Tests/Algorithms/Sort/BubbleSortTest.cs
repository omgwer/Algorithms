using Algorithms.Algorithms.Sort;

namespace Tests.Algorithms.Sort;

public class BubbleSortTest() : BaseSortTest(Sortable)
{
    private static readonly ISortable Sortable = new BubbleSort();
}