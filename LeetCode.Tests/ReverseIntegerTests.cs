using Xunit;

namespace LeetCode.Tests;

public class ReverseIntegerTests
{
    private readonly ReverseInteger _solver = new();

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
    // Overflow when reversed should return 0
    [InlineData(1534236469, 0)] // example from LeetCode
    [InlineData(-1563847412, 0)]
    [InlineData(int.MaxValue, 0)] // 2147483647 -> 7463847412 (overflow)
    [InlineData(int.MinValue, 0)] // -2147483648 reversed overflows
    public void Reverse_OverflowCases_ReturnsZero(int input, int expected)
    {
        var actual = _solver.Reverse(input);
        Assert.Equal(expected, actual);
    }
}