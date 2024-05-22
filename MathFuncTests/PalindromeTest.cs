using HomeWork;
namespace FuncTests
{
    public class PalindromeTests
    {
        [Test]
        public void TestIsPalindrome_ValidPalindrome()
        {
            string teststr = "ƒа, искать такси - ад!";

            bool result = Func.IsPalindrome(teststr);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestIsPalindrome_EmptyString()
        {
            string emptyString = "";

            bool result = Func.IsPalindrome(emptyString);

            Assert.IsFalse(result);
        }

        [Test]
        public void TestIsPalindrome_InvalidPalindrome()
        {
            string invalidPalindrome = "Ёто строка не палиндром";

            bool result = Func.IsPalindrome(invalidPalindrome);

            Assert.IsFalse(result);
        }

        [Test]
        public void TestIsPalindrome_SingleCharacter()
        {
            string singleCharacter = "a";

            bool result = Func.IsPalindrome(singleCharacter);

            Assert.IsFalse(result);
        }

    }
}
