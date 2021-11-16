using System.Text.Json.Serialization;

namespace Gulliver.Busca.Api.Views
{
    public class Hotel
    {
        [JsonPropertyName("rating")]
        public int Rating { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("img")]
        public string Img { get; set; }

        [JsonPropertyName("textDescription")]
        public string TextDescription { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("averageOfStay")]
        public string AverageOfStay { get; set; }
    }
}