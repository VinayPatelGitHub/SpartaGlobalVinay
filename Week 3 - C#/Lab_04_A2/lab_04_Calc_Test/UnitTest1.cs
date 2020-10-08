using NUnit.Framework;
using Lab4_A2___class_library_file;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace lab_04_Calc_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
 
        }

        [TestCase(10, 2, 4, 80)]
        [TestCase(0, -3, 7, 0)]
        [TestCase(1, 2, 3, 6)]
        
        public void ProductIsCorrect(int a, int b, int c, int expected)
        {
            var actual = TripleCalc.Calc(a, b, c, out int sum);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 2, 4, 16)]
        [TestCase(0, -3, 7, 4)]
        [TestCase(1, 2, 3, 6)]
        public void SumIsCorrect(int a, int b, int c, int expected)
        {
            TripleCalc.Calc(a, b, c, out int sum);
            Assert.AreEqual(expected, sum);
        }
    }
}