using System;
using System.Text.Json.Serialization;

namespace Gulliver.Busca.Api.Models
{
    public class SearchMetadata
    {
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("processed_at")]
        public DateTime ProcessedAt { get; set; }

        [JsonPropertyName("total_time_taken")]
        public double TotalTimeTaken { get; set; }

        [JsonPropertyName("engine_url")]
        public string EngineUrl { get; set; }

        [JsonPropertyName("html_url")]
        public string HtmlUrl { get; set; }

        [JsonPropertyName("json_url")]
        public string JsonUrl { get; set; }
    }

}