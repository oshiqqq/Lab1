using HomeWork;
namespace FuncTests
{
    public class FindSubstringTests
    {
        [Test]
        public void TestFindSubstring_FoundSubstring()
        {
            string text = "Hello world";
            string pattern = "world";

            bool result = Func.FindSubstring(text, pattern);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestFindSubstring_NotFoundSubstring()
        {
            string text = "Hello world";
            string pattern = "earth";

            bool result = Func.FindSubstring(text, pattern);

            Assert.IsFalse(result);
        }

        [Test]
        public void TestFindSubstring_EmptyPattern()
        {
            string text = "Hello world";
            string pattern = "";

            bool result = Func.FindSubstring(text, pattern);

            Assert.IsTrue(result); // Пустая строка считается подстрокой любой строки
        }

    }
}
