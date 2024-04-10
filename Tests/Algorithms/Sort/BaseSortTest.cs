using Algorithms.Algorithms.Sort;

namespace Tests.Algorithms.Sort;

public class BaseSortTest
{
    private readonly ISortable sorter;
    
    public BaseSortTest(ISortable sorter)
    {
        this.sorter = sorter;
    }

    [Theory]
    [InlineData(new int[] { })]
    [InlineData(new [] { 1 })]
    [InlineData(new [] { 1,1 })]
    [InlineData(new [] { 1,2 })]
    [InlineData(new [] { 1,1,2 })]
    [InlineData(new [] { -1,0 })]
    [InlineData(new [] { -1,1 })]
    [InlineData(new [] { -1,-1 })]
    public void Sort_NotNeedSort(int[] array)
    {
        // Arrange
        // Act
        int[] sortedValue = sorter.Sort(array);
        // Assert
        Assert.Equal(sortedValue, array);
    }

    [Theory]
    [InlineData(new [] { 1,0 }, new []{0,1})]
    [InlineData(new [] { 1,2,3 }, new []{1,2,3})]
    [InlineData(new [] { 3,2,1 }, new []{1,2,3})]
    [InlineData(new [] { 0,-5,11 }, new []{-5, 0 ,11})]
    public void Sort_Sorted_TwoDigits(int[] array, int[] expectedArray)
    {
        // Act
        int[] sortedValue = sorter.Sort(array);
        // Assert
        Assert.Equal(sortedValue, expectedArray);
    }
}