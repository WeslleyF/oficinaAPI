using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OficinaAPI.Modelo.Classes;
using OficinaAPI.Servico.Interfaces;
using OficinaAPI.core.classes.Controllers;

namespace OficinaAPI.Controllers
{
    [Route("api/Cliente")]
    [ApiController]    public class ClienteController : CrudController<Cliente>
    {
        public ClienteController(IServico<Cliente> servicoCliente) : base (servicoCliente)
        {
            
        }

        protected override Func<Cliente, bool>? getWhere()
        {
            return null;
        }
    }
}
