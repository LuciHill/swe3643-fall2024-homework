using hw2_Calculator;
namespace StdDevCalcTests
{
    public class NullListTests
    {
        TestDelegate MeanTest(int[] numbers)
        {
            StdDevCalculator calc = new StdDevCalculator();
            void TestDelegate() => calc.ComputeMean(numbers);

            return TestDelegate;
        }
        
        TestDelegate SqofDiffTest(int[] numbers)
        {
            StdDevCalculator calc = new StdDevCalculator();
            void TestDelegate() => calc.ComputeSqofDiff(numbers, 2.5);

            return TestDelegate;
        }
        
        TestDelegate VariancePopTest(int[] numbers)
        {
            int numVals  = numbers.Length;
            StdDevCalculator calc = new StdDevCalculator();
            void TestDelegate() => calc.ComputeVariance(2.5, numVals, true);

            return TestDelegate;
        }
        
        TestDelegate SampleStdDevTest(int[] numbers)
        {
            
            StdDevCalculator calc = new StdDevCalculator();
            void TestDelegate() => calc.ComputeSampleStdDev(numbers);

            return TestDelegate;
        }
        
        TestDelegate PopStdDevTest(int[] numbers)
        {
            StdDevCalculator calc = new StdDevCalculator();
            void TestDelegate() => calc.ComputePopStdDev(numbers);

            return TestDelegate;
        }
        
        [Test]
        public void MeanPassingTest()
        {
            int[] numbers = [];
            Assert.Throws<Exception>(MeanTest(numbers));

        }
        [Test]
        public void MeanFailingTest()
        {
            int[] numbers = [1,2,3,4,5,6,7,8,9,10];
            Assert.DoesNotThrow(MeanTest(numbers));
        }
        [Test]
        public void SqofDiffPassingTest()
        {
            int[] numbers = [];
            Exception exception = Assert.Throws<Exception>(SqofDiffTest(numbers));
            Assert.That(exception.Message, Is.EqualTo("Cannot compute Square of Difference. The data set is empty"));
        }
        [Test]
        public void SqofDiffFailingTest()
        {
            int[] numbers = [1,2,3,4,5,6,7,8,9,10];
            Assert.DoesNotThrow(SqofDiffTest(numbers));
        }
        [Test]
        public void VarPassingTest()
        {
            int[] numbers = [];
            Exception exception = Assert.Throws<Exception>(VariancePopTest(numbers));
            Assert.That(exception.Message, Is.EqualTo("Unable to calculate variance. Sample size can not be less than 1 when calculating Standard Deviation for a population."));
        }
        [Test]
        public void VarFailingTest()
        {
            int[] numbers = [1,2,3,4,5,6,7,8,9,10];
            Assert.DoesNotThrow(VariancePopTest(numbers));
        }
        
        [Test]
        public void StdPopPassingTest()
        {
            int[] numbers = [];
            Exception exception = Assert.Throws<Exception>(PopStdDevTest(numbers));
            Assert.That(exception.Message, Is.EqualTo("Cannot compute Standard Deviation. The data set is empty"));
        }
        [Test]
        public void StdPopFailingTest()
        {
            int[] numbers = [1,2,3,4,5,6,7,8,9,10];
            Assert.DoesNotThrow(PopStdDevTest(numbers));
        }
        [Test]
        public void StdSamplePassingTest()
        {
            int[] numbers = [];
            Exception exception = Assert.Throws<Exception>(SampleStdDevTest(numbers));
            Assert.That(exception.Message, Is.EqualTo("Cannot compute Standard Deviation. The data set is empty"));
        }
        [Test]
        public void StdSampleFailingTest()
        {
            int[] numbers = [1,2,3,4,5,6,7,8,9,10];
            Assert.DoesNotThrow(SampleStdDevTest(numbers));
        }
    }
}