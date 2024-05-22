using HomeWork;
namespace FuncTests
{
    public class IsPrimeNumberTests
    {
        [Test]
        public void TestIsPrimeNumber_Prime()
        {
            int primeNumber = 17;

            bool result = Func.IsPrimeNumber(primeNumber);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestIsPrimeNumber_Composite()
        {
            int compositeNumber = 25;

            bool result = Func.IsPrimeNumber(compositeNumber);

            Assert.IsFalse(result);
        }

        [Test]
        public void TestIsPrimeNumber_One()
        {
            int one = 1;

            bool result = Func.IsPrimeNumber(one);

            Assert.IsFalse(result);
        }
    }
}
