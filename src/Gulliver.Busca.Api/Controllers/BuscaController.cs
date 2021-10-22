using System.Net;
using System.Threading.Tasks;
using Gulliver.Busca.Api.Configuration;
using Gulliver.Busca.Api.Services;
using Gulliver.Busca.Api.Views;
using Microsoft.AspNetCore.Mvc;

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
            request.SetApiKey(_appSettings.SerpConfiguration.ApiKey);
            
            return Ok(await _buscaService.BuscarCatalogo(request));
        }
        
    }
}