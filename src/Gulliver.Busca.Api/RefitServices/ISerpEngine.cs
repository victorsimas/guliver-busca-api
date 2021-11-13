using System.Threading.Tasks;
using Gulliver.Busca.Api.Models;
using Refit;

namespace Gulliver.Busca.Api.RefitServices
{
    public interface ISerpEngine
    {
        [Get("/search")]
        Task<SerpEngineResponse> GetSearchResult(SerpEngineRequest request);
    }
}