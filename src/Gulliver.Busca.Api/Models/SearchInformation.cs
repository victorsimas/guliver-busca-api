using System.Text.Json.Serialization;

namespace Gulliver.Busca.Api.Models
{
    public class SearchInformation
    {
        [JsonPropertyName("original_query_yields_zero_results")]
        public bool OriginalQueryYieldsZeroResults { get; set; }

        [JsonPropertyName("query_displayed")]
        public string QueryDisplayed { get; set; }

        [JsonPropertyName("detected_location")]
        public string DetectedLocation { get; set; }
    }

}