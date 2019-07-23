using DFDS.Interfaces;
using DFDS.Models.OpenCage;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

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
            var apiKey = ConfigurationManager.AppSettings["OpenCageApiKey"];
            request.AddQueryParameter("key", apiKey);
            return request;
        }

        private RestClient GetClient()
        {
            //Assuming these configuration values are in a secure place
            var url = ConfigurationManager.AppSettings["OpenCageApiUrl"];
            var client = new RestClient(url);
            return client;
        }

    }
}