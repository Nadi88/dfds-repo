using DFDS.Interfaces;
using DFDS.Models.OpenCage;
using RestSharp;
using System.Configuration;

namespace DFDS.DataAccess
{
    public class OpenCageDal : ILocation
    {
        public string GetCountry(double latitude, double longitude)
        {
            var client = GetClient();
            var request = GetRequest();

            request.AddQueryParameter("q", $"{latitude},{longitude}");
            request.Method = Method.GET;

            var response = client.Execute<ReverseGeoCodingResponse>(request);

            return response.Data?.results[0]?.components?.country;
        }

        private RestRequest GetRequest()
        {
            var request = new RestRequest();
            //Assuming configuration values/api keys etc are in a secure place
            var apiKey = ConfigurationManager.AppSettings["OpenCageApiKey"];
            request.AddQueryParameter("key", apiKey);
            return request;
        }

        private RestClient GetClient()
        {
            var url = ConfigurationManager.AppSettings["OpenCageApiUrl"];
            var client = new RestClient(url);
            return client;
        }

    }
}