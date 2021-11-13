using System.Text.Json.Serialization;

namespace Gulliver.Busca.Api.Models
{
    public class Expanded
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }
    }
}