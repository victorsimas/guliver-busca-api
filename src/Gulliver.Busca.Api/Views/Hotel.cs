using System.Text.Json.Serialization;

namespace Gulliver.Busca.Api.Views
{
    public class Hotel
    {
        [JsonPropertyName("rating")]
        public int Rating { get; set; }

        [JsonPropertyName("ratingStars")]
        public string RatingStars { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("img")]
        public string Img { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("textDescription")]
        public string TextDescription { get; set; }

        [JsonPropertyName("whenTravel")]
        public string WhenTravel { get; set; }

        [JsonPropertyName("averageTemperature")]
        public string AverageTemperature { get; set; }

        [JsonPropertyName("timeZone")]
        public string TimeZone { get; set; }

        [JsonPropertyName("averageOfStay")]
        public string AverageOfStay { get; set; }
    }
}