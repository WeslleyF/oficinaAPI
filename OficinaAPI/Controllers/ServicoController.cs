using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OficinaAPI.Modelo.Classes;
using OficinaAPI.Servico.Interfaces;
using OficinaAPI.core.classes.Controllers;

namespace OficinaAPI.Controllers
{
    [Route("api/servico")]
    [ApiController]    
    public class ServicoController : CrudController<OficinaAPI.Modelo.Classes.Servico>
    {
        public ServicoController(IServico<OficinaAPI.Modelo.Classes.Servico> servicoServico) : base (servicoServico)
        {
            
        }

        protected override Func<OficinaAPI.Modelo.Classes.Servico, bool>? getWhere()
        {
            return null;
        }

        [HttpGet]
        [Route("lista")]
        public IActionResult lista()
        {
            return new JsonResult(_servico.RecuperarTodos(null));
        }
    }
}
