using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OficinaAPI.Modelo.Classes;
using OficinaAPI.Servico.Interfaces;
using OficinaAPI.core.classes.Controllers;

namespace OficinaAPI.Controllers
{
    [Route("api/bairro")]
    [ApiController]    public class BairroController : CrudController<Bairro>
    {
        public BairroController(IServico<Bairro> servicoBairro) : base (servicoBairro)
        {
            
        }

        protected override Func<Bairro, bool>? getWhere()
        {
            string codCidade = HttpContext.Request.Query["codCidade"].ToString();
            return b => b.CodCidade == codCidade;
        }
    }
}
