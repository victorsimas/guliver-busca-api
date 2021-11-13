using Gulliver.Busca.Api.Models;

namespace Gulliver.Busca.Api.Views
{
    public class BuscaRequest
    {
        public string Local { get; set; }

        private string ApiKey { get; set; }

        public void SetApiKey(string apiKey)
        {
            ApiKey = apiKey;
        }

        public string GetApiKey()
        {
            return ApiKey;
        }

        public static explicit operator SerpEngineRequest(BuscaRequest buscaRequest)
        {
            return new SerpEngineRequest()
            {
                Local = buscaRequest.Local.Replace(" ", "+"),
                Gl = "br",
                Hl = "pt",
                Output = "json",
                GoogleDomain = "google.com.br",
                SearchType = "places",
                ApiKey = buscaRequest.GetApiKey()
            };
        }
    }
}