using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OficinaAPI.Modelo.Classes;
using OficinaAPI.Servico.Interfaces;
using OficinaAPI.core.classes.Controllers;
using Microsoft.AspNetCore.Http;

namespace OficinaAPI.Controllers
{
    [Route("api/cidade")]
    [ApiController]    
    public class CidadeController : CrudController<Cidade>
    {
        public CidadeController(IServico<Cidade> servicoCidade) : base (servicoCidade)
        {
       
        }

        protected override Func<Cidade, bool>? getWhere()
        {
          string uf = HttpContext.Request.Query["uf"].ToString();
          return c => c.UF == uf;
        }
    }
}
