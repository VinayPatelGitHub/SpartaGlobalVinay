using Newtonsoft.Json;
using System.Web.UI;

namespace FixerWalkthough
{
    public class FixerLatestDTO
    {
        //DataTransferModel
        //This class is the model of the data returned by the API call

        public LatestRatesRoot LatestRates { get; set; }        
        
        public void DeserializeLatestRates(string latestRatesResponse)
        {
            LatestRates = JsonConvert.DeserializeObject<LatestRatesRoot>(latestRatesResponse);
        }
    }
}
