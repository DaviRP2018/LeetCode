using Xunit;

namespace LeetCode.Tests;

public class LetterCombinationsTests
{
    private readonly LetterCombinations _solver = new();

    private static void AssertEquivalent(IEnumerable<string> expected, IList<string> actual)
    {
        Assert.NotNull(actual);
        var expectedSorted = expected.OrderBy(s => s).ToArray();
        var actualSorted = actual.OrderBy(s => s).ToArray();
        Assert.Equal(expectedSorted.Length, actualSorted.Length);
        for (var i = 0; i < expectedSorted.Length; i++)
            Assert.Equal(expectedSorted[i], actualSorted[i]);
    }

    [Theory]
    [InlineData(new[] { "a", "b", "c" }, "2")]
    [InlineData(new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" }, "23")]
    [InlineData(
        new[]
        {
            "adg", "adh", "adi", "aeg", "aeh", "aei", "afg", "afh", "afi", "bdg", "bdh", "bdi",
            "beg", "beh", "bei", "bfg", "bfh", "bfi", "cdg", "cdh", "cdi", "ceg", "ceh", "cei",
            "cfg", "cfh", "cfi"
        }, "234")]
    [InlineData(
        new[]
        {
            "adgj", "adgk", "adgl", "adhj", "adhk", "adhl", "adij", "adik", "adil", "aegj", "aegk",
            "aegl", "aehj", "aehk", "aehl", "aeij", "aeik", "aeil", "afgj", "afgk", "afgl", "afhj",
            "afhk", "afhl", "afij", "afik", "afil", "bdgj", "bdgk", "bdgl", "bdhj", "bdhk", "bdhl",
            "bdij", "bdik", "bdil", "begj", "begk", "begl", "behj", "behk", "behl", "beij", "beik",
            "beil", "bfgj", "bfgk", "bfgl", "bfhj", "bfhk", "bfhl", "bfij", "bfik", "bfil", "cdgj",
            "cdgk", "cdgl", "cdhj", "cdhk", "cdhl", "cdij", "cdik", "cdil", "cegj", "cegk", "cegl",
            "cehj", "cehk", "cehl", "ceij", "ceik", "ceil", "cfgj", "cfgk", "cfgl", "cfhj", "cfhk",
            "cfhl", "cfij", "cfik", "cfil"
        }, "2345")]
    public void LetterCombinations_ReturnsCorrectCombinations(string[] expected, string digits)
    {
        var actual = _solver.Solution(digits);
        AssertEquivalent(expected, actual);
    }
}