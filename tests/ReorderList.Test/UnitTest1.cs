using core;
namespace ReorderList.Test;

public class UnitTest1
{
    [Theory]
    [InlineData("bbbbb",1)]
    [InlineData("abcabcbb",3)]
    [InlineData("pwwkew",3)]
    public void TestCasesReorderList(string s, int expected)
    {
        var resultado = Solution.LengthOfLongestSubstring(s);
        Assert.Equal(expected, resultado);
    }
}
