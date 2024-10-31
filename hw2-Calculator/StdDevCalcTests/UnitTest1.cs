using hw2_Calculator;
namespace StdDevCalcTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            StdDevCalculator calc = new StdDevCalculator();
            int[] numbers = [1,2,3,4,5,6,7,8,9,10,11];
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}