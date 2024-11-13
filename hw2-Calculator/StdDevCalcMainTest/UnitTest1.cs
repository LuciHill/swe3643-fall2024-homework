
namespace StdDevCalcMainTest;

public class StdDev_Main_Test
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void MainTest()
    {
        int[] nums = [1, 2, 3, 4, 5, 6, 7];
        StdDevCalculator calc = new StdDevCalculator();
        Assert.Pass();
    }
}