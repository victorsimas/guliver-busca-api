using System.Threading.Tasks;
using Gulliver.Busca.Api.Views;

namespace Gulliver.Busca.Api.Services
{
    public interface IBuscaService
    {
        Task<BuscaResponse> BuscarCatalogo(BuscaRequest request);
        
    }
}