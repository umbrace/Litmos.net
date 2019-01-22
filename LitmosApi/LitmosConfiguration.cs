namespace LitmosApi
{
    public class LitmosConfiguration : ILitmosConfiguration
    {
        public string ApiKey { get; set; }
        public string Source { get; set; } = "litmosDotNetSdk";
    }
}