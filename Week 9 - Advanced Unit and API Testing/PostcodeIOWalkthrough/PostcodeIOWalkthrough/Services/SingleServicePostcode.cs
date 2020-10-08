using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostcodeIOWalkthrough
{
    public class SingleServicePostcode
    {
        public RestClient client { get; set; }
        public JObject PostcodeSingleResponseContent { get; set; }
        public string PostcodeSelected { get; set; }

        public SingleServicePostcode()
        {
            client = new RestClient { BaseUrl = new Uri("https://api.postcodes.io") };
        }

        public void GetSinglePostcode(string postcode)
        {
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");
            PostcodeSelected = postcode;
            request.Resource = $"postcodes/{postcode.ToLower().Replace(" ", "")}";
            var response = client.Execute(request);
            PostcodeSingleResponseContent = JObject.Parse(response.Content);
        }

    }
}
