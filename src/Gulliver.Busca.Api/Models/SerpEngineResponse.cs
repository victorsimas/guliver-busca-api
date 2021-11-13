using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Gulliver.Busca.Api.Models
{
    public class SerpEngineResponse
    {
        [JsonPropertyName("request_info")]
        public RequestInfo RequestInfo { get; set; }

        [JsonPropertyName("search_metadata")]
        public SearchMetadata SearchMetadata { get; set; }

        [JsonPropertyName("search_parameters")]
        public SearchParameters SearchParameters { get; set; }

        [JsonPropertyName("search_information")]
        public SearchInformation SearchInformation { get; set; }

        [JsonPropertyName("places_results")]
        public List<PlacesResult> PlacesResults { get; set; }
    }
}