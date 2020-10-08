using NUnit.Framework;

namespace AdvancedNUnit
{
    [TestFixture]    
    public class CounterTests
    {
        [Test]
        public void Increment_IncreaseCountByOne()
        {
            Counter _sut = new Counter(6);
            _sut.Increment();
            Assert.That(_sut.Count, Is.EqualTo(7));
        }
        [Ignore("Decrement_DecreasesCountByOne not ready for testing yet")]
        [Test]
        public void Decrement_DecreasesCountByOne()
        {
            Counter _sut = new Counter(6);
            _sut.Decrement();
            Assert.That(_sut.Count, Is.EqualTo(5));
        }

    }
}
