using HomeWork;

namespace FuncTests
{
    public class BubbleSortTests
    {
        [Test]
        public void TestBubbleSort_SortedArray()
        {

            int[] sortedArray = { 1, 2, 3, 4, 5 };

            int[] result = Func.BubbleSort(sortedArray);

            int[] expected = { 1, 2, 3, 4, 5 };
            Assert.That(result, Is.EqualTo(expected).AsCollection);
        }

        [Test]
        public void TestBubbleSort_UnsortedArray()
        {
        
            int[] unsortedArray = { 5, 3, 1, 4, 2 };

            int[] result = Func.BubbleSort(unsortedArray);

            int[] expected = { 1, 2, 3, 4, 5 };
            Assert.That(result, Is.EqualTo(expected).AsCollection);
        }


        [Test]
        public void TestBubbleSort_SingleElementArray()
        {
  
            int[] singleElementArray = { 42 };

            int[] result = Func.BubbleSort(singleElementArray);

            int[] expected = { 42 };
            Assert.That(result, Is.EqualTo(expected).AsCollection);
        }

        [Test]
        public void TestBubbleSort_DuplicateElementsArray()
        {
            int[] duplicateElementsArray = { 3, 1, 2, 3, 1 };

            int[] result = Func.BubbleSort(duplicateElementsArray);

            int[] expected = { 1, 1, 2, 3, 3 };
            Assert.That(result, Is.EqualTo(expected).AsCollection);
        }
    }
}
