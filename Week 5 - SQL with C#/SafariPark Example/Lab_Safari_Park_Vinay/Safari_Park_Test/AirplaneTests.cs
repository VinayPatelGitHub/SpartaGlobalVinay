using NUnit.Framework;
using Safari_Park;
namespace ClassesTests
{
    public class AirplaneTests
    {
        Airplane a;

        [SetUp]
        public void Setup()
        {
            a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
        }
        

        [Test]
        public void test1()
        {
            a.Ascend(500);
            var result = a.Move(3);
            Assert.AreEqual("Moving along 3 times at an altitude of 500 metres.", result);
        }

        [Test]
        public void test2()
        {
            a.Ascend(500);
            a.Move(3);
            var result = a.ToString();
            Assert.AreEqual("Thank you for flying JetsRUs: ClassessApp.Airplane capacity: 200 passengers: 150 speed: 100 position: 300 altitude: 500.", result);
        }


        [Test]
        public void test3()
        {
            a.Ascend(500);
            a.Move(3);
            a.Descend(200);
            var result = a.Move();
            Assert.AreEqual("Moving along at an altitude of 300 metres.", result);
        }

        [Test]
        public void test4()
        {
            a.Ascend(500);
            a.Move(3);
            a.Descend(200);
            a.Move();
            a.Move();
            var result = a.ToString();
            Assert.AreEqual("Thank you for flying JetsRUs: ClassessApp.Airplane capacity: 200 passengers: 150 speed: 100 position: 500 altitude: 300.", result);
        }

    }
}



