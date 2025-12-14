namespace LeetCode;

public class LetterCombinations
{
    public static readonly Dictionary<char, string> Map = new()
    {
        ['2'] = "abc",
        ['3'] = "def",
        ['4'] = "ghi",
        ['5'] = "jkl",
        ['6'] = "mno",
        ['7'] = "pqrs",
        ['8'] = "tuv",
        ['9'] = "wxyz"
    };

    public IList<string> Solution(string digits)
    {
        var availableLetters = new List<string>();
        foreach (var digit in digits) availableLetters.Add(Map[digit]);

        var result = new List<string>();

        void Recursive(int index, string combination = "")
        {
            foreach (var letter in availableLetters[index])
            {
                combination += letter;
                if (index != availableLetters.Count - 1)
                    Recursive(index + 1, combination);
                else
                    result.Add(combination);
                combination = combination.Remove(combination.Length - 1);
            }
        }

        Recursive(0);
        return result;
    }
}