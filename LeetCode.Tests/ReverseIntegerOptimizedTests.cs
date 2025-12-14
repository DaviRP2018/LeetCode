using Xunit;

namespace LeetCode.Tests;

public class ReverseIntegerOptimizedTests
{
    private readonly ReverseIntegerOptimized _solver = new();

    [Theory]
    [InlineData(123, 321)]
    [InlineData(120, 21)]
    [InlineData(0, 0)]
    public void Reverse_PositiveNumbers_Works(int input, int expected)
    {
        var actual = _solver.Reverse(input);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(-123, -321)]
    [InlineData(-120, -21)]
    public void Reverse_NegativeNumbers_Works(int input, int expected)
    {
        var actual = _solver.Reverse(input);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1534236469, 0)]
    [InlineData(-1563847412, 0)]
    [InlineData(int.MaxValue, 0)]
    [InlineData(int.MinValue, 0)]
    public void Reverse_OverflowCases_ReturnsZero(int input, int expected)
    {
        var actual = _solver.Reverse(input);
        Assert.Equal(expected, actual);
    }
}