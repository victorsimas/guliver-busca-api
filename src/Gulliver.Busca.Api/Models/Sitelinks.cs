using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Gulliver.Busca.Api.Models
{
    public class Sitelinks
    {
        [JsonPropertyName("inline")]
        public List<Inline> Inline { get; set; }

        [JsonPropertyName("expanded")]
        public List<Expanded> Expanded { get; set; }
    }
}