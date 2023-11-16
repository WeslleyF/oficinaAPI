using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OficinaAPI.Modelo.Classes;
using OficinaAPI.Servico.Interfaces;

namespace OficinaAPI.Controllers
{
    [Route("api/estado")]
    [ApiController]
    public class EstadoController : CrudController<Estado>
    {
        public EstadoController(IServico<Estado> servicoEstado) : base (servicoEstado)
        {
            
        }

        protected override Func<Estado, bool>? getWhere()
        {
            return null;
        }
    }
}
