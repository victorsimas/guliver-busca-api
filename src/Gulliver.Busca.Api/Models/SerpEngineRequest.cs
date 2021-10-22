using Refit;

namespace Gulliver.Busca.Api.Models
{
    public class SerpEngineRequest
    {
        [AliasAs("q")]
        public string Query { get; set; }

        [AliasAs("google_domain")]
        public string GoogleDomain { get; set; }

        [AliasAs("gl")]
        public string Gl { get; set; }

        [AliasAs("hl")]
        public string Hl { get; set; }

        [AliasAs("search_type")]
        public string SearchType { get; set; }

        [AliasAs("output")]
        public string Output { get; set; }

        [AliasAs("api_key")]
        public string ApiKey { get; set; }
    }
}