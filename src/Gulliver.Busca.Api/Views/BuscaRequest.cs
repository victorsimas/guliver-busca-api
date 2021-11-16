using Gulliver.Busca.Api.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Gulliver.Busca.Api.Views
{
    public class BuscaRequest
    {
        public string Local { get; set; }

        [BindNever]
        public string ApiKey { get; private set; }

        public void SetApiKey(string apiKey)
        {
            ApiKey = apiKey;
        }

        public static explicit operator SerpEngineRequest(BuscaRequest buscaRequest)
        {
            return new SerpEngineRequest()
            {
                Local = buscaRequest.Local.Replace(" ", "+"),
                Query = buscaRequest.Local.Replace(" ", "+"),
                Gl = "br",
                Hl = "pt",
                Output = "json",
                GoogleDomain = "google.com.br",
                ApiKey = buscaRequest.ApiKey
            };
        }
    }
}