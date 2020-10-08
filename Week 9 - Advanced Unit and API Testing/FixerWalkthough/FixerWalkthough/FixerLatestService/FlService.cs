using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixerWalkthough
{
    public class FlService
    {
        //Our instance of the call manager that manages te call to the API to get the data
        public FixerLatestCallManager FixerLatestCallManager { get; set; } = new FixerLatestCallManager();

        //Deserialiser that transforms out data into the format for out model
        public FixerLatestDTO FixerLatestDTO { get; set; } = new FixerLatestDTO();

        //String contains last set of rates retrieved
        public string LiveRates { get; set; }

        //Rates converted back into JObject
        public JObject Json_rates { get; set; }
        //public JObject Json_rates_Selected { get; set; }

        public FlService()
        {
            // storing the string from the API call made by the fixerlatestcallmanager
            LiveRates = FixerLatestCallManager.GetLatestRates();
            //Deserialize to a JObject
            FixerLatestDTO.DeserializeLatestRates(LiveRates);
            Json_rates = JsonConvert.DeserializeObject<JObject>(LiveRates);
        }

        //public FlService(string[] inputs)
        //{
        //    // storing the string from the API call made by the fixerlatestcallmanager
        //    LiveRates = FixerLatestCallManager.GetLatestRates();
        //    //Deserialize to a JObject            
        //    FixerLatestDTO.DeserializeLatestRates(LiveRates);
        //    Json_rates = JsonConvert.DeserializeObject<JObject>(LiveRates);

        //    foreach (var item in inputs)
        //    {
        //        foreach (var pair in Json_rates)
        //        {
        //            if (item == pair.Key)
        //            {
        //                Json_rates_Selected.Add(pair);
        //            }
        //        }
        //    }           

        //}

        public int RatesCount()
        {
            return Json_rates["rates"].Count();
        }



        //public string[] CopyToTextFile()
        //{
        //    string inputText = "sup";
        //    System.IO.File.AppendAllText(@"C:\GitHub\SpartaGlobalVinay\FixerWalkthough\SavedData.txt", inputText);
        //    string[] outputText = System.IO.File.ReadAllLines(@"C:\GitHub\SpartaGlobalVinay\FixerWalkthough\SavedData.txt");
        //    return outputText;
        //}

    }
}
