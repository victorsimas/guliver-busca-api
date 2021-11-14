using System.Collections.Generic;
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
            BuscaResponse buscaResponse = new();

            await Task.WhenAll(
                BuscarHoteis(request, buscaResponse),
                ConfigurarHistoria(request, buscaResponse),
                ConfigurarCultura(request, buscaResponse),
                ConfigurarGastronomia(request, buscaResponse),
                ConfigurarParques(request, buscaResponse),
                ConfigurarVidaNortuna(request, buscaResponse),
                ConfigurarEntreterimento(request, buscaResponse)
            );

            return buscaResponse;
        }

        private async Task ConfigurarHistoria(BuscaRequest request, BuscaResponse buscaResponse)
        {
            buscaResponse.History = await ComplementarBusca(request, "Historia");
        }

        private async Task ConfigurarCultura(BuscaRequest request, BuscaResponse buscaResponse)
        {
            buscaResponse.Culture = await ComplementarBusca(request, "Cultura");
        }

        private async Task ConfigurarGastronomia(BuscaRequest request, BuscaResponse buscaResponse)
        {
            buscaResponse.Gastronomy = await ComplementarBusca(request, "Gastronomia");
        }

        private async Task ConfigurarParques(BuscaRequest request, BuscaResponse buscaResponse)
        {
            buscaResponse.Parks = await ComplementarBusca(request, "Parques");
        }

        private async Task ConfigurarVidaNortuna(BuscaRequest request, BuscaResponse buscaResponse)
        {
            buscaResponse.NightLife = await ComplementarBusca(request, "Vida Noturna");
        }

        private async Task ConfigurarEntreterimento(BuscaRequest request, BuscaResponse buscaResponse)
        {
            buscaResponse.Entertainment = await ComplementarBusca(request, "Entreterimento");
        }

        private async Task BuscarHoteis(BuscaRequest request, BuscaResponse buscaResponse)
        {
            SerpEngineRequest requestSerp = (SerpEngineRequest)request;

            requestSerp.Query = "Hotel";
            requestSerp.SearchType = "places";

            SerpEngineResponse serpResponse = await _serpEngine.GetSearchResult(requestSerp);

            buscaResponse.Hotels = _mapper.Map<List<Hotel>>(serpResponse.PlacesResults);
        }

        private async Task<Categoria> ComplementarBusca(BuscaRequest request, string topico)
        {
            SerpEngineResponse serpReponse = new();
            (List<OrganicResult> organics, List<ImageResult> images) tupla = new();

            await Task.WhenAll(
                BuscaOrganica(serpReponse, request, topico),
                BuscaImagens(serpReponse, request, topico)
            );

            tupla.organics = serpReponse.OrganicResults;
            tupla.images = serpReponse.ImageResults;

            return _mapper.Map<Categoria>(tupla);
        }

        private async Task BuscaOrganica(SerpEngineResponse serpReponse, BuscaRequest request, string topico)
        {
            SerpEngineRequest requestSerp = (SerpEngineRequest)request;

            requestSerp.Query = topico;

            SerpEngineResponse serpResponseTemp = await _serpEngine.GetSearchResult(requestSerp);

            serpReponse.OrganicResults = serpResponseTemp.OrganicResults;
        }

        private async Task BuscaImagens(SerpEngineResponse serpReponse, BuscaRequest request, string topico)
        {
            SerpEngineRequest requestSerp = (SerpEngineRequest)request;

            requestSerp.Query = topico;
            requestSerp.SearchType = "images";

            SerpEngineResponse serpResponseTemp = await _serpEngine.GetSearchResult(requestSerp);

            serpReponse.ImageResults = serpResponseTemp.ImageResults;
        }
    }
}