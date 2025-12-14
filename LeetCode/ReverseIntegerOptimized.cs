namespace LeetCode;

public sealed class ReverseIntegerOptimized
{
    public int Reverse(int x)
    {
        var result = 0;

        while (x != 0)
        {
            var pop = x % 10;
            x /= 10;

            // Check for overflow/underflow before multiplying by 10 and adding pop
            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && pop > 7))
                return 0;
            if (result < int.MinValue / 10 || (result == int.MinValue / 10 && pop < -8))
                return 0;

            result = result * 10 + pop;
        }

        return result;
    }
}