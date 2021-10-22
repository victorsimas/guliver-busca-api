using System.Threading.Tasks;
using Gulliver.Busca.Api.Models;
using Gulliver.Busca.Api.RefitServices;
using Gulliver.Busca.Api.Views;

namespace Gulliver.Busca.Api.Services
{
    public class BuscaService : IBuscaService
    {
        private readonly ISerpEngine _serpEngine;
        public BuscaService(ISerpEngine serpEngine)
        {
            _serpEngine = serpEngine;
        }

        public async Task<BuscaResponse> BuscarCatalogo(BuscaRequest request)
        {
            SerpEngineResponse serpResponse = await _serpEngine.GetSearchResult((SerpEngineRequest) request);

            BuscaResponse buscaResponse = (BuscaResponse) serpResponse;

            return buscaResponse;
        }
    }
}