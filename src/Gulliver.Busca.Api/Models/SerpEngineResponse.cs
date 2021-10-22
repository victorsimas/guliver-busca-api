using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Gulliver.Busca.Api.Views;

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

        public static explicit operator BuscaResponse(SerpEngineResponse serpEngineResponse)
        {
            PlacesResult place = serpEngineResponse.PlacesResults.FirstOrDefault();

            return new BuscaResponse()
            {
                Title = place?.Title,
                Text = place?.Description
            };
        }
    }
}