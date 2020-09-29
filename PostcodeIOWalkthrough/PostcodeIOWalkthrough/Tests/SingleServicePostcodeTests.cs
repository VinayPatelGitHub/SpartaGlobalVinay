using System;
using NUnit.Framework;

namespace PostcodeIOWalkthrough
{
    public class SingleServicePostcodeTests
    {
        SingleServicePostcode _singleServicePostcode = new SingleServicePostcode();
        public SingleServicePostcodeTests()
        {
            _singleServicePostcode.GetSinglePostcode("se120nb");
        }

        [Test]
        public void StatusIs200()
        {
            Assert.That(_singleServicePostcode.PostcodeSingleResponseContent["status"].ToString(), Is.EqualTo("200"));
        }

        [Test]
        public void ReturnsCorrectPostcode()
        {
            Assert.That(_singleServicePostcode.PostcodeSingleResponseContent["result"]["postcode"].ToString(), Is.EqualTo("SE12 0NB"));
        }

        [Test]
        public void ReturnsCorrectAdminCounty()
        {
            Assert.That(_singleServicePostcode.PostcodeSingleResponseContent["result"]["codes"]["admin_county"].ToString(), Is.EqualTo("E99999999"));
        }


    }
}
