using RestSharp;
using System;

namespace LitmosApi
{
    public partial class LitmosApiClient
    {
        private readonly LitmosConfiguration _configuration;
        public const string BaseUrl = "https://api.litmos.com/v1.svc/";

        public LitmosApiClient(LitmosConfiguration configuration)
        {
            _configuration = configuration;
        }

        public T Get<T>(RestRequest request) where T : new()
        {
            var client = new RestClient
            {
                BaseUrl = new System.Uri(BaseUrl)
            };
            request.AddOrUpdateParameter("apikey", _configuration.ApiKey, ParameterType.QueryString);
            request.AddOrUpdateParameter("source", "litmosDotNetSdk", ParameterType.QueryString);

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
