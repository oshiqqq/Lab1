using HomeWork;
namespace FuncTests
{
    public class IntToRomanTests
    {
        [Test]
        public void TestIntToRoman_Conversion()
        {
            int num = 3214;

            string result = Func.IntToRoman(num);

            Assert.That(result, Is.EqualTo("MMMCCXIV"));
        }
        [Test]
        public void TestIntToRoman_Thousands()
        {
            int num = 3214;

            string result = Func.IntToRoman(num);

            Assert.That(result.Substring(0, 3), Is.EqualTo("MMM")); // Проверяем, что первые три символа - "MMM"
        }

        [Test]
        public void TestIntToRoman_Hundreds()
        {
            int num = 3214;

            string result = Func.IntToRoman(num);

            Assert.That(result.Substring(3, 2), Is.EqualTo("CC")); // Проверяем, что следующие два символа - "CC"
        }


    }
}