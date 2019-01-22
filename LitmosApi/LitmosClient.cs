using RestSharp;
using System;

namespace LitmosApi
{
    public partial class LitmosClient
    {
        private readonly LitmosConfiguration _configuration;
        public const string BaseComUrl = "https://api.litmos.com/v1.svc/";
        public const string BaseEuUrl = "https://api.litmoseu.com/v1.svc/";
        public const string BaseAuUrl = "https://api.litmos.com.au/v1.svc/";

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
            var baseUrl = GetBaseUrl();
            var client = new RestClient
            {
                BaseUrl = new System.Uri(baseUrl)
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

        private string GetBaseUrl()
        {
            string baseUrl;
            switch (_configuration.Site)
            {
                case LitmosConfiguration.SiteType.Com:
                    baseUrl = BaseComUrl;
                    break;
                case LitmosConfiguration.SiteType.Eu:
                    baseUrl = BaseEuUrl;
                    break;
                case LitmosConfiguration.SiteType.Au:
                    baseUrl = BaseAuUrl;
                    break;
                default:
                    throw new NotImplementedException($"the siteType {_configuration.Site} is not supported");
            }

            return baseUrl;
        }
    }
}
