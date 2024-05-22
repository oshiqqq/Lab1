using NUnit.Framework;
using HomeWork;

namespace FuncTests
{
    public class FactorialTests
    {
        [Test]
        public void TestFactorial_PositiveNumber()
        {
            int number = 5;

            int result = Func.Factorial(number);

            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        public void TestFactorial_Zero()
        {
            int number = 0;

            int result = Func.Factorial(number);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void TestFactorial_NegativeNumber()
        {
            int number = -1;

            int result = Func.Factorial(number);

            Assert.That(result, Is.EqualTo(0));
        }
    }
}
