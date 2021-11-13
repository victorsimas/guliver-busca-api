using System.Text.Json.Serialization;

namespace Gulliver.Busca.Api.Models
{
    public class SearchParameters
    {
        [JsonPropertyName("q")]
        public string Query { get; set; }

        [JsonPropertyName("google_domain")]
        public string GoogleDomain { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("gl")]
        public string Gl { get; set; }

        [JsonPropertyName("hl")]
        public string Hl { get; set; }

        [JsonPropertyName("search_type")]
        public string SearchType { get; set; }

        [JsonPropertyName("output")]
        public string Output { get; set; }
    }

}