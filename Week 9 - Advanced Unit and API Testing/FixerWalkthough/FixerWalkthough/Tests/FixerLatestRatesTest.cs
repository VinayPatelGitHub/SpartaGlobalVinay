using FixerWalkthough;
using NUnit.Framework;

namespace FixerWalkthrough
{
    public class FixerLatestRatesTest
    {
        // create an instance of FixerLatestService (FLService)
        private FlService _fixerLatestRates = new FlService();

        [Test]
        public void CheckStatusIs200()
        {
            Assert.That(_fixerLatestRates.FixerLatestDTO.LatestRates.success);
        }

        [Test]
        public void WebCallSuccessCheckUsingJobject()
        {
            Assert.That(_fixerLatestRates.Json_rates["success"].ToString(), Is.EqualTo("True"));
        }

        [Test]
        public void CheckNumberofRates()
        {
            Assert.That(_fixerLatestRates.RatesCount(), Is.EqualTo(168));
        }

        //[Test]
        //public void WriteToFile()
        //{
        //    Assert.That(_fixerLatestRates.CopyToTextFile(), Is.EqualTo("sup"));
        //}

        //[Test]
        //public void WebCallSelectedCheck()
        //{
        //    string[] input = { "GBP" };
        //    FlService _fixerLatestRatesSelected = new FlService(input);
        //    Assert.That(_fixerLatestRatesSelected.Json_rates_Selected.ToString(), Is.EqualTo("True"));

        //}
    }
}

