using System.Text.Json.Serialization;

namespace Gulliver.Busca.Api.Models
{
    public class GpsCoordinates
    {
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }
    }

}