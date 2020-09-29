using System;
using NUnit.Framework;

namespace PostcodeIOWalkthrough.Tests
{
    public class BulkServicePostcodeTests
    {
        BulkServicePostcode _bulkServicePostcode = new BulkServicePostcode();
        public BulkServicePostcodeTests()
        {
            _bulkServicePostcode.GetBulkPostcode("[\r\n        \"PR3 0SG\",\r\n        \"M45 6GN\",\r\n        \"EX165BL\"\r\n    ]");
        }

        [Test]
        public void StatusIs200()
        {
            Assert.That(_bulkServicePostcode.PostcodeBulkResponseContent["status"].ToString(), Is.EqualTo("200"));
        }

        [Test]
        public void CorrectPostCodeReturn()
        {
            Assert.That(_bulkServicePostcode.PostcodeBulkResponseContent["result"][0]["result"]["postcode"].ToString(), Is.EqualTo("PR3 0SG"));
        }
    }
    
}
