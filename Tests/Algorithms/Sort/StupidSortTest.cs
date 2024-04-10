using Algorithms.Algorithms.Sort;

namespace Tests.Algorithms.Sort;

public class StupidSortTest() : BaseSortTest(Sortable)
{
    private static readonly ISortable Sortable = new StupidSort();
}