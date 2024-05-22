using HomeWork;
namespace FuncTests
{
    public class ReverseDigitsTests
    {
        [Test]
        public void TestReverseDigits_PositiveNumber()
        {
            int num = 1234;

            int result = Func.ReverseDigits(num);

            Assert.That(result, Is.EqualTo(4321));
        }

        [Test]
        public void TestReverseDigits_NegativeNumber()
        {
            int num = -1234;

            int result = Func.ReverseDigits(num);

            Assert.That(result, Is.EqualTo(-4321));
        }

        [Test]
        public void TestReverseDigits_Overflow()
        {
            int num = int.MaxValue;

            int result = Func.ReverseDigits(num);

            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void TestReverseDigits_OverflowAfterReverse()
        {
            int num = int.MaxValue - 1; 

            int result = Func.ReverseDigits(num);

            Assert.That(result, Is.EqualTo(0));
        }

    }
}
