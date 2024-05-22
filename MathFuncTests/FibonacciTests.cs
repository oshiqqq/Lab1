using HomeWork;
namespace FuncTests
{
    public class FibonacciTests
    {
        [Test]
        public void TestFibonacci_NegativeNumber()
        {
            int negativeNumber = -3;

            int result = Func.Fibonacci(negativeNumber);

            Assert.That(result, Is.EqualTo(negativeNumber));
        }

        [Test]
        public void TestFibonacci_LargeNumber()
        {
            int largeNumber = 20;

            int result = Func.Fibonacci(largeNumber);

            Assert.That(result, Is.EqualTo(6765));
        }

        [Test]
        public void TestFibonacci_WrongNumber()
        {
            int zero = 0;
   
            int result = Func.Fibonacci(zero);

            Assert.That(result, Is.EqualTo(zero));
        }

        [Test]
        public void TestFibonacci_PositiveNumber()
        {
            int positiveNumber = 6;

            int result = Func.Fibonacci(positiveNumber);

            Assert.That(result, Is.EqualTo(8));
        }
    }
}
