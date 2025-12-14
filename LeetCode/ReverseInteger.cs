namespace LeetCode;

public class ReverseInteger
{
    public int Reverse(int x)
    {
        try
        {
            var reverse = "";
            var tmp = x.ToString();

            if (tmp[0] == '-')
            {
                tmp = tmp.Substring(1);
                reverse = $"-{string.Join("", tmp.Reverse())}";
            }
            else
            {
                reverse = string.Join("", tmp.Reverse());
            }

            x = int.Parse(reverse);
            return x;
        }
        catch (OverflowException)
        {
            return 0;
        }
    }
}