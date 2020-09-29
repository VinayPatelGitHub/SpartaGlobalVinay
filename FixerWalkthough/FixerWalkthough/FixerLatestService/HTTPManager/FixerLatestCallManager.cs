using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixerWalkthough
{
    public class FixerLatestCallManager
    {
        //The restsharp object which handles the call
        readonly IRestClient _client;

        public FixerLatestCallManager()
        {
            _client = new RestClient(FixerConfigReader.BaseUrl);
        }
        
        public string GetLatestRates()
        {
            var request = new RestRequest("/latest" + FixerConfigReader.ApiUrlMod + FixerConfigReader.ApiKey);
            var response = _client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}
