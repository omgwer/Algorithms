using Algorithms.Algorithms.Sort;

namespace Tests.Algorithms.Sort;

public class ShakerSortTest() : BaseSortTest(Sortable)
{
    private static readonly ISortable Sortable = new ShakerSort();
}