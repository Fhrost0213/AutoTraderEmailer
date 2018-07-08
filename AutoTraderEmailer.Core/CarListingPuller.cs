using System;
using System.Collections.Generic;
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

        public CarListingPuller(CarListingCriteria criteria)
        {
            _url = BuildUrlFromParameters(criteria);
            //_url =
              //  "https://www.autotrader.com/rest/searchresults/sunset/base?zip=75098&startYear=2018&numRecords=100&sortBy=relevance&firstRecord=0&endYear=2018&modelCodeList=TRAVERSE&makeCodeList=CHEV&searchRadius=100";

            _client = new HttpClient();
            _client.BaseAddress = new Uri(_url);
        }

        public List<JsonObjects.Listing> GetListings()
        {
            var client = new RestClient(_url);
            var request = new RestRequest(Method.GET);

            var response = client.Execute(request);

            var rootObject = JsonConvert.DeserializeObject<JsonObjects.Rootobject>(response.Content);
            return rootObject.listings.ToList();
        }

        private string BuildUrlFromParameters(CarListingCriteria criteria)
        {
            bool isFirst = true;
            var baseUrl = "https://www.autotrader.com/rest/searchresults/sunset/base";

            var builder = new StringBuilder();
            builder.Append(baseUrl);

            var properties = criteria.GetType().GetProperties();

            foreach (var property in properties)
            {
                if (isFirst)
                {
                    builder.Append("?" + property.Name + "=" + property.GetValue(criteria, null));
                    isFirst = false;
                }
                else
                {
                    if (property.Name == "trimCodeList")
                    {
                        // TODO: Don't understand why this appends this in front of trim, need to see if there's a cleaner way to call this API
                        builder.Append("&" + property.Name + "=" + criteria.modelCodeList + "%7C" + property.GetValue(criteria, null));
                    }
                    else
                    {
                        
                    }
                    builder.Append("&" + property.Name + "=" + property.GetValue(criteria, null));
                    
                }
            }

            return builder.ToString();
        }
    }
}
