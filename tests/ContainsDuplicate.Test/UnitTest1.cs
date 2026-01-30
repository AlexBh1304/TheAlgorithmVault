using core;
namespace ContainsDuplicate.Test;

public class UnitTest1
{
    [Theory]
    [MemberData(nameof(CasosDePrueba))]
    public void containsDuplicateTrue(int[] nums, bool duplicate)
    {
        var result = Program.hasDuplicate3(nums);
        Assert.Equal(duplicate, result);
    }

    public static IEnumerable<object[]> CasosDePrueba =>
        new List<object[]>
        {
          new object[]{new int[]{1,2,3,4,5},false},
          new object[]{new int[]{1,3,6,1,4}, true}  
        };
}
