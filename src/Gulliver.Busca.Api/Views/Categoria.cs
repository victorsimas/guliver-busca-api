using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Gulliver.Busca.Api.Views
{
    public class Categoria
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("img")]
        public string Img { get; set; }

        [JsonPropertyName("imgs")]
        public List<string> Imgs { get; set; }
    }

}