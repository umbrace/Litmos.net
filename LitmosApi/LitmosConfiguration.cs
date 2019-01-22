using LitmosApi.ExtentionMethods;

namespace LitmosApi
{
    public class LitmosConfiguration : ILitmosConfiguration
    {
        public enum SiteType
        {
            /// <summary>
            /// Default
            /// </summary>
            Com,

            /// <summary>
            /// Clients using the EU Litmos site
            /// </summary>
            Eu,

            /// <summary>
            /// Clients using the Australian Litmos site
            /// </summary>
            Au
        }

        private string _source = "litmosDotNetSdk";

        /// <summary>
        /// Free text description of your app. Usually a company or product name.
        /// </summary>
        /// <value>The source.</value>
        public string Source
        {
            get => _source;
            set => _source = value.Truncate(50);
        }

        public SiteType Site { get; set; } = LitmosConfiguration.SiteType.Com;
        public string ApiKey { get; set; }
    }
}