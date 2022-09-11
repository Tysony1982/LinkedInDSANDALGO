using APlusB;
namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(100)]
        public void Test1(int n)
        {
            Program.RunFibonacci(n);
        }

        [TestCase(0,'0')]
        [TestCase(1,'1')]
        [TestCase(2,'1')]
        [TestCase(3,'2')]
        [TestCase(100,'1')]
        public void Test2(int n, char expected)
        {
            var last = Program.GetLastDigitOfLargeFib(n);
            Assert.That(last, Is.EqualTo(expected));
        }
    }
}