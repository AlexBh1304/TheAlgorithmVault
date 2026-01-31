using core;
namespace ValidAnagram.Test;

public class UnitTest1
{
    [Theory]
    [InlineData("racecar", "carrace", true)]
    [InlineData("jar", "jam", false)]
    public void validAnagram(string a, string b, bool result)
    {
        var x = Solution.isAnagram2(a,b);
        Assert.Equal(x,result);
    }
}
