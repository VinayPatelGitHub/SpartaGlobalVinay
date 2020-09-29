using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostcodeIOWalkthrough
{
    class BulkServicePostcode
    {
        public RestClient client { get; set; }
        public JObject PostcodeBulkResponseContent { get; set; }
        public string PostcodeSelected { get; set; }

        public BulkServicePostcode()
        {
            client = new RestClient { BaseUrl = new Uri("https://api.postcodes.io/postcodes/") };
        }

        public void GetBulkPostcode(string postcode)
        {
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            //request.AddParameter("application/json", "{\r\n    \"postcodes\": [\r\n        \"PR3 0SG\",\r\n        \"M45 6GN\",\r\n        \"EX165BL\"\r\n    ]\r\n}", ParameterType.RequestBody);
            request.AddJsonBody("{\r\n    \"postcodes\": [\r\n        \"PR3 0SG\",\r\n        \"M45 6GN\",\r\n        \"EX165BL\"\r\n    ]\r\n}");
            var response = client.Execute(request);
            PostcodeBulkResponseContent = JObject.Parse(response.Content);
        }








    }
}