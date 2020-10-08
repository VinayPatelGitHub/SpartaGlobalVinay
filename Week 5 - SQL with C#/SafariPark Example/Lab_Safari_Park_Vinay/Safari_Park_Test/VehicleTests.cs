using NUnit.Framework;
using Safari_Park;
namespace ClassesTests
{
    public class VehicleTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times", result);
        }


        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }

        public void WhenAVehicleWithSpeed30IsMovedTriceItsPositionIs90()
        {
            Vehicle v = new Vehicle(5, 30);
            var result = v.Move(3);
            Assert.AreEqual(90, v.Position);
            Assert.AreEqual("Moving along 3 times", result);
        }

        [TestCase(-1, 0)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(3, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 5)]
        public void VehicleCapacityTests(int numPassengers, int expectedPassengers)
        {
            Vehicle v = new Vehicle(5)
            {
                NumPassengers = numPassengers
            };
            Assert.AreEqual(expectedPassengers, v.NumPassengers);
        }

        //[Test]
        //public void PrivatePostion()
        //{
        //    vehicle v = new vehicle(5, 10);
        //    v.position = 6; //can't run
        //    assert.areequal(10, v.position);
        //}





    }
}
