using core; 
namespace _11.ContainerWithMostWater.Test;

public class UnitTest1
{
    [Theory]
    [MemberData(nameof(CasosDePrueba))]
    public void TestCasesContainerWithMostWater(int[] height, int output)
    {
        var resultado = Solution.MaxArea(height);
        Assert.Equal(resultado,output);
    }



    // se usa esto para cuando se quiere pasar como argumento un array o una lista  colección
    public static IEnumerable<object[]> CasosDePrueba =>
        new List<object[]>
        {
          new object[]{new int[]{1,8,6,2,5,4,8,3,7},49},
          new object[]{new int[]{1,2,3,1000,9},9},
          new object[]{new int[]{1,1},1}   
        };
}
