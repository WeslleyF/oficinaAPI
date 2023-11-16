using Microsoft.AspNetCore.Mvc;
using OficinaAPI.Modelo.Interface;
using OficinaAPI.Servico.Interfaces;

namespace OficinaAPI.Controllers
{
    [ApiController]
    public abstract class CrudController<Entidade> : ControllerBase where Entidade : class, IEntidade
    {
        protected readonly IServico<Entidade> _servico;
        public CrudController(IServico<Entidade> servico)
        {
            _servico = servico;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Adicionar([FromBody] Entidade entidade)
        {
            return new JsonResult(await _servico.Adicionar(entidade));
        }

        [HttpPut]
        [Route("")]
        public IActionResult Atualizar([FromBody] Entidade entidade)
        {
            return new JsonResult(_servico.Atualizar(entidade));
        }

        [HttpDelete]
        [Route("")]
        public IActionResult remover([FromBody] Entidade entidade)
        {
            return new JsonResult(_servico.Remover(entidade));
        }

        [HttpGet]
        [Route("")]
        public IActionResult recuperar()
        {
            return new JsonResult(_servico.Recuperar(getWhere()));
        }

        [HttpGet]
        [Route("{codKey}")]
        public async Task<IActionResult> recuperar(string codKey)
        {
            return new JsonResult(await _servico.Recuperar(codKey));
        }

        protected abstract Func<Entidade, bool>? getWhere();
    }
}
