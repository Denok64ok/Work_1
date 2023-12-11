
namespace PMT_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EvenProcessString()
        {
            string input = "a";

            string actual = Task.ProcessString(input);

            string expected = "aa";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void OddProcessString()
        {
            string input = "abcdef";

            string actual = Task.ProcessString(input);

            string expected = "cbafed";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void LowercaseGetInvalidCharacters()
        {
            string input = "zXc";

            string actual = Task.GetInvalidCharacters(input);

            string expected = "X";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void NotLowercaseGetInvalidCharacters()
        {
            string input = "zxc";

            string actual = Task.GetInvalidCharacters(input);

            string expected = "";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CountCharacters()
        {
            string input = "asa";

            List<string> actual = Task.CountCharacters(input);

            List<string> expected = new();
            expected.Add("Количество символов a в обработанной строке = 2");
            expected.Add("Количество символов s в обработанной строке = 1");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void VowelFindLongestSubstring()
        {
            string input = "cbafed";

            string actual = Task.FindLongestSubstring(input);

            string expected = "afe";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void NotVowelFindLongestSubstring()
        {
            string input = "edcbaabcde";

            string actual = Task.FindLongestSubstring(input);

            string expected = "edcbaabcde";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void QuickSortAlgorithm()
        {
            string input = "cab";

            var sortActual = new QuickSortAlgorithm();
            var sortResult = input.ToCharArray();
            sortActual.Sort(sortResult);

            string expected = "abc";

            Assert.That(sortResult, Is.EqualTo(expected));
        }

        [Test]
        public void TreeSortAlgorithm()
        {
            string input = "cab";

            var sortActual = new TreeSortAlgorithm();
            var sortResult = input.ToCharArray();
            sortActual.Sort(sortResult);

            string expected = "abc";

            Assert.That(sortResult, Is.EqualTo(expected));
        }
    }
}