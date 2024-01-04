using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OficinaAPI.Modelo.Classes;
using OficinaAPI.Servico.Interfaces;
using OficinaAPI.core.classes.Controllers;

namespace OficinaAPI.Controllers
{
    [Route("api/nota-servico")]
    [ApiController]    
    public class NotaServicoController : ControllerBase
    {
        private readonly INotaServicoServico _notaServicoServico;
        public NotaServicoController(INotaServicoServico notaServicoServico)
        {
          _notaServicoServico = notaServicoServico;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Adicionar([FromBody] NotaServico notaServico)
        {
            return new JsonResult(notaServico);
        }

    }
}
