using System.Text.Json.Serialization;

namespace Gulliver.Busca.Api.Models
{
    public class ImageResult
    {
        [JsonPropertyName("position")]
        public int Position { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("domain")]
        public string Domain { get; set; }

        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("brand")]
        public string Brand { get; set; }
    }
}