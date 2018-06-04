using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using RestSharp;

namespace AutoTraderEmailer.Core
{
    public class CarListingPuller
    {
        private string urlParameters = "";
        private HttpClient _client;
        private string _url;

        public CarListingPuller(CarListingParameters parameters)
        {
            _url = BuildUrlFromParameters(parameters);
            //_url =
              //  "https://www.autotrader.com/rest/searchresults/sunset/base?zip=75098&startYear=2018&numRecords=100&sortBy=relevance&firstRecord=0&endYear=2018&modelCodeList=TRAVERSE&makeCodeList=CHEV&searchRadius=100";

            _client = new HttpClient();
            _client.BaseAddress = new Uri(_url);
        }

        public void GetListings()
        {
            var client = new RestClient(_url);
            var request = new RestRequest(Method.GET);

            var response = client.Execute(request);

            var rootObject = JsonConvert.DeserializeObject<JsonObjects.Rootobject>(response.Content);
            var listings = rootObject.listings;
            var listingsByPrice = listings.OrderBy(x => x.derivedPrice);

        }

        private string BuildUrlFromParameters(CarListingParameters parameters)
        {
            var baseUrl = "https://www.autotrader.com/rest/searchresults/sunset/base";

            var builder = new StringBuilder();
            builder.Append(baseUrl);

            var properties = parameters.GetType().GetProperties();

            foreach (var property in properties)
            {
                builder.Append("&" + property.Name + "=" + property.GetValue(parameters, null));
            }

            return builder.ToString();
        }
    }
}
