using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using Lab_5_Selection;

namespace lab_5_selection_test
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [TestCase(40)]
        [TestCase(41)]
        [TestCase(50)]
        [TestCase(100)]
        public void PassTest(int x)
        {
            var results = Lab_5_Selection.Program.PassFail(x);
            Assert.AreEqual("Pass", results);
        }
        [TestCase(39)]
        [TestCase(30)]
        [TestCase(0)]
        [TestCase(15)]
        public void FailTest(int x)
        {
            var results = Lab_5_Selection.Program.PassFail(x);
            Assert.AreEqual("Fail", results);
        }

        [TestCase(100)]
        [TestCase(75)]
        public void Mark75AndOverPasseswithDistinction(int mark)
        {
            var results = Lab_5_Selection.Program.Grade(mark);
            Assert.AreEqual("Pass with Distinction", results);
        }

        [TestCase(74)]
        [TestCase(60)]
        public void Mark60AndOverPasseswithMerit(int mark)
        {
            var results = Lab_5_Selection.Program.Grade(mark);
            Assert.AreEqual("Pass with Merit", results);
        }

        [TestCase(3, "Code Red")]
        [TestCase(2, "Code Amber")]
        [TestCase(1, "Code Amber")]
        [TestCase(0, "Code Green")]
        [TestCase(7, "Error")]
        public void PriorityTest (int level, string expected)
        {
            var results = Lab_5_Selection.Program.Priority(level);
            Assert.AreEqual(expected, results);
        }
    }
}