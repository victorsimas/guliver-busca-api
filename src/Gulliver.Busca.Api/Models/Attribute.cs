using System.Text.Json.Serialization;

namespace Gulliver.Busca.Api.Models
{
    public class Attribute
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}