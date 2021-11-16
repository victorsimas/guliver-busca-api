using System.Net;
using System.Threading.Tasks;
using Gulliver.Busca.Api.Configuration;
using Gulliver.Busca.Api.Services;
using Gulliver.Busca.Api.Views;
using Microsoft.AspNetCore.Mvc;
using src.Gulliver.Busca.Api.Views;

namespace Gulliver.Busca.Api.Controllers
{
    [Route("busca")]
    public class BuscaController : Controller
    {
        private readonly IBuscaService _buscaService;
        private readonly AppSettings _appSettings;

        public BuscaController(IBuscaService buscaService, AppSettings appSettings)
        {
            _buscaService = buscaService;
            _appSettings = appSettings;
        }

        [HttpGet]
        [ProducesResponseType(typeof(BuscaResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAsync(BuscaRequest request)
        {
            try
            {
                request.SetApiKey(_appSettings.SerpConfiguration.ApiKey);
                
                return Ok(await _buscaService.BuscarCatalogo(request));
            }
            catch(Refit.ApiException ex)
            {
                ErrorMessage mensagem = new() { Message = ex.Message };
                return (ex.StatusCode) switch{
                    HttpStatusCode.PaymentRequired => StatusCode((int)HttpStatusCode.FailedDependency, mensagem),
                    HttpStatusCode.Unauthorized => StatusCode((int)HttpStatusCode.FailedDependency, mensagem),
                    HttpStatusCode.Forbidden => StatusCode((int)HttpStatusCode.FailedDependency, mensagem),
                    _ => StatusCode((int)HttpStatusCode.BadGateway, mensagem)
                };
            }
        }
        
    }
}