
using NUnit.Framework;
using homework1;
namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void PassingTest()
        {
            Assert.AreEqual(4, Calculator.Add(2,2));
        }
        [Test]
        public void FailingTest()
        {
            Assert.AreEqual(5, Calculator.Add(2,2));
        }
    }
}