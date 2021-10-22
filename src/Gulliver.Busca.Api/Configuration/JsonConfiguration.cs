using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Gulliver.Busca.Api.Configuration
{
    public static class JsonConfiguration
    {
        public static readonly JsonSerializerOptions JsonSerializerOptions;
        public static readonly TextEncoderSettings TextEncoderSettings = new();

        static JsonConfiguration()
        {
            TextEncoderSettings.AllowRanges(UnicodeRanges.BasicLatin, UnicodeRanges.Latin1Supplement);

            JsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true,
                IgnoreReadOnlyProperties = true,
                IgnoreNullValues = false,
                WriteIndented = false,
                Encoder = JavaScriptEncoder.Create(TextEncoderSettings)
            };
        }
    }
}
