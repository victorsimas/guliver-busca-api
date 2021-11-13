using System.Text.Json.Serialization;

namespace Gulliver.Busca.Api.Models
{
    public class PlacesResult
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("data_cid")]
        public string DataCid { get; set; }

        [JsonPropertyName("gps_coordinates")]
        public GpsCoordinates GpsCoordinates { get; set; }

        [JsonPropertyName("sponsored")]
        public bool Sponsored { get; set; }

        [JsonPropertyName("position")]
        public int Position { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("unclaimed")]
        public bool Unclaimed { get; set; }

        [JsonPropertyName("data_id")]
        public string DataId { get; set; }

        [JsonPropertyName("snippet")]
        public string Snippet { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("rating")]
        public double Rating { get; set; }

        [JsonPropertyName("reviews")]
        public int Reviews { get; set; }
    }

}