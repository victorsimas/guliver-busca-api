using System.Text.Json.Serialization;

namespace Gulliver.Busca.Api.Models
{
    public class RequestInfo
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("topup_credits_remaining")]
        public int TopupCreditsRemaining { get; set; }

        [JsonPropertyName("credits_used_this_request")]
        public int CreditsUsedThisRequest { get; set; }
    }

}