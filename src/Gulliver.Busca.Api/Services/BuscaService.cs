using System.Threading.Tasks;
using AutoMapper;
using Gulliver.Busca.Api.Models;
using Gulliver.Busca.Api.RefitServices;
using Gulliver.Busca.Api.Views;

namespace Gulliver.Busca.Api.Services
{
    public class BuscaService : IBuscaService
    {
        private readonly ISerpEngine _serpEngine;
        private readonly IMapper _mapper;

        public BuscaService(ISerpEngine serpEngine, IMapper mapper)
        {
            _serpEngine = serpEngine;
            _mapper = mapper;
        }

        public async Task<BuscaResponse> BuscarCatalogo(BuscaRequest request)
        {
            SerpEngineRequest requestSerp = (SerpEngineRequest)request;
            SerpEngineResponse serpResponse = await BuscarHoteis(requestSerp);

            BuscaResponse buscaResponse = _mapper.Map<BuscaResponse>(serpResponse);

            return buscaResponse;
        }

        private async Task<SerpEngineResponse> BuscarHoteis(SerpEngineRequest requestSerp)
        {
            requestSerp.Query = "Hotel";

            SerpEngineResponse serpResponse = await _serpEngine.GetSearchResult(requestSerp);
            return serpResponse;
        }
    }
}