using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace AdvancedNUnit
{
    [TestFixture]
    public class Tests
    {
        [OneTimeSetUp]
        public void Setup() { }

        [Category("Nish Examples")]
        [Test]
        public void Add_Always_ReturnsExpectedResult()
        {
            // Arrange
            var subject = new Calculator();
            // Act
            var result = subject.Add(2, 4);
            // Assert
            Assert.AreEqual(6, result);
        }
        [Category("Nish Examples")]
        [Test]
        public void ConstraintModelAddMethod()
        {
            // Arrange
            var subject = new Calculator();
            // Act
            var result = subject.Add(2, 4);
            // Assert
            Assert.That(result, Is.EqualTo(6));
            Assert.That(subject.DivisibleBy3(6));
            Assert.That(subject.DivisibleBy3(7), Is.False);
            Assert.That(subject.ToString(), Does.Contain("Calculator"));
        }
        [Category("Nish Examples")]
        [Test]
        public void TestArrayofString()
        {
            var fruit = new List<string> { "apple", "pear", "bananna", "peach" };
            Assert.That(fruit, Does.Contain("pear"));
            Assert.That(fruit, Has.Count.EqualTo(4));
            Assert.That(fruit, Has.Exactly(2).StartsWith("pea"));
        }
        [Category("Nish Examples")]
        [Test]
        public void TestRange()
        {
            List<int> nums = new List<int> { 4, 2, 7, 5, 9 };
            Assert.That(nums, Is.All.InRange(1, 10));
            Assert.That(nums, Has.Exactly(3).InRange(1, 5));
        }
        [Category("Nish Examples")]
        [Test]
        public void ExceptionTests()
        {
            var subject = new Calculator();
            Assert.That(() => subject.Divide(5, 0), Throws.ArgumentException.With.Message.EqualTo("Can't divide by 0"));
        }



        [Category("Example of differences in errors")]
        [Test]
        public void nonConstraintModelListTests()
        {
            List<int> myList = new List<int> { 1, 2, 3 };
            Assert.AreEqual(1, myList.Where(x => x == 4).Count());
        }
        [Category("Example of differences in errors")]
        [Test]
        public void ConstraintModelListTests()
        {
            List<int> myList = new List<int> { 1, 2, 3 };
            Assert.That(myList, Has.Exactly(1).EqualTo(4));
        }

        [Category("NormalTestCases")]
        [TestCase (5, 2, 3)]
        [TestCase(2, 5, -3)]
        [TestCase(-100, 5, -105)]
        [TestCase(-5, 50, -55)]
        [TestCase(20, -10, 30)]
        [TestCase(20, -30, 50)]
        [TestCase(-10, -9, -1)]
        [TestCase(-9, -10, 1)]
        public void ConstraintModeSubtraction(int x, int y, int expectedResult)
        {
            // Arrange
            var subject = new Calculator();
            // Act
            var result = subject.Subtract(x, y);
            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Category("TestCase using an 2D Array input")]
        [TestCaseSource("AddCases")]
        public void ConstraintModeMultiplyAuto(int x, int y, int expectedResult)
        {
            // Arrange
            var subject = new Calculator();
            // Act
            var result = subject.Multiply(x, y);
            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        public static object[] AddCases =
        {
            new int[] {2,4,8},
            new int[] {-2,3,-6},
        };
    }
    
}