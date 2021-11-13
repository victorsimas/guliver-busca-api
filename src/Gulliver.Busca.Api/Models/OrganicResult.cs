using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Gulliver.Busca.Api.Models
{
    public class OrganicResult
    {
        [JsonPropertyName("position")]
        public int Position { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("domain")]
        public string Domain { get; set; }

        [JsonPropertyName("displayed_link")]
        public string DisplayedLink { get; set; }

        [JsonPropertyName("snippet")]
        public string Snippet { get; set; }

        [JsonPropertyName("prerender")]
        public bool Prerender { get; set; }

        [JsonPropertyName("snippet_matched")]
        public List<string> SnippetMatched { get; set; }

        [JsonPropertyName("cached_page_link")]
        public string CachedPageLink { get; set; }

        [JsonPropertyName("related_page_link")]
        public string RelatedPageLink { get; set; }

        [JsonPropertyName("sitelinks")]
        public Sitelinks Sitelinks { get; set; }

        [JsonPropertyName("sitelinks_search_box")]
        public bool SitelinksSearchBox { get; set; }

        [JsonPropertyName("prefix")]
        public string Prefix { get; set; }

        [JsonPropertyName("block_position")]
        public int BlockPosition { get; set; }
    }
}