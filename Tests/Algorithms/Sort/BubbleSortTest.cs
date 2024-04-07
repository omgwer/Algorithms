using Algorithms.Algorithms.Sort;

namespace Tests.Algorithms.Sort;

public class BubbleSortTest
{
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
        int[] sortedValue = array.Sort();
        // Assert
        Assert.Equal(sortedValue, array);
    }

    [Theory]
    [InlineData(new [] { 1,0 }, new []{0,1})]
    public void Sort_Sorted_TwoDigits(int[] array, int[] expectedArray)
    {
        // Act
        int[] sortedValue = array.Sort();
        // Assert
        Assert.Equal(sortedValue, expectedArray);
    }
}