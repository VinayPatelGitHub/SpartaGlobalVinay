using NUnit.Framework;
using FizzBuzzApp;
using System;

namespace FizzBuzzTest
{
    public class FizzBuzzShould
    {
        [Test]
        public void GivenOne_Return_OneString()
        {
            Assert.That(Program.FizzBuzz(1), Is.EqualTo("1"));
        }

        [Test]
        public void Given3_Return_Fizz()
        {
            Assert.That(Program.FizzBuzz(3), Is.EqualTo("Fizz"));
        }

        [Test]
        public void Given5_Return_Buzz()
        {
            Assert.That(Program.FizzBuzz(5), Is.EqualTo("Buzz"));
        }

        [Test]
        public void Given15_Return_FizzBuzz()
        {
            Assert.That(Program.FizzBuzz(15), Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GivenMultipleof3_Return_Fizz()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 100);
            while (num % 5 == 0)
            {
                num = rnd.Next(1, 100);
            }
            Assert.That(Program.FizzBuzz(3*rnd.Next(1, 10)), Is.EqualTo("Fizz"));
        }

        [Test]
        public void GivenMultipleof5_Return_Fizz()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 100);
            while (num % 3 == 0)
            {
                num = rnd.Next(1, 100);
            }
            Assert.That(Program.FizzBuzz(5 * num), Is.EqualTo("Buzz"));
        }

        [Test]
        public void GivenMultipleof15_Return_Fizz()
        {
            Random rnd = new Random();
            Assert.That(Program.FizzBuzz(15 * rnd.Next(1, 10)), Is.EqualTo("FizzBuzz"));
        }

    }
}
