using RestSharp;
using System;

namespace LitmosApi
{
    public partial class LitmosClient
    {
        private readonly LitmosConfiguration _configuration;
        public const string BaseUrl = "https://api.litmos.com/v1.svc/";

        public LitmosClient(string apiKey)
        : this(new LitmosConfiguration() { ApiKey = apiKey })
        {
        }

        public LitmosClient(LitmosConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected T Get<T>(RestRequest request) where T : new()
        {
            var client = new RestClient
            {
                BaseUrl = new System.Uri(BaseUrl)
            };
            request.AddOrUpdateParameter("apikey", _configuration.ApiKey, ParameterType.QueryString);
            request.AddOrUpdateParameter("source", _configuration.Source, ParameterType.QueryString);

            var response = client.Get<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                throw new ApplicationException(message, response.ErrorException);
            }
            return response.Data;
        }
    }
}
