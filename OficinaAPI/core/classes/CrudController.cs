﻿using Microsoft.AspNetCore.Mvc;
using OficinaAPI.Modelo.Interface;
using OficinaAPI.Servico.Interfaces;

namespace OficinaAPI.core.classes.Controllers
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
        [Route("{codKey}")]
        public async Task<IActionResult> remover(string codKey)
        {
            Entidade? obj;
            int intkey;
            
            if (int.TryParse(codKey, out intkey))
              obj = await _servico.Recuperar(intkey);
            else 
              obj = await _servico.Recuperar(codKey);
            
            if(obj is null) return new JsonResult(null);

            return new JsonResult(_servico.Remover(obj));
        }

        [HttpGet]
        [Route("")]
        public IActionResult recuperar()
        {
            return new JsonResult(_servico.RecuperarTodos(getWhere()));
        }

        [HttpGet]
        [Route("{codKey}")]
        public async Task<IActionResult> recuperar(string codKey)
        {
            Task<Entidade?> result;
            int intkey;
            
            if (int.TryParse(codKey, out intkey))
              result = _servico.Recuperar(intkey);
            else 
              result = _servico.Recuperar(codKey);

            return new JsonResult(await result);
        }

        protected abstract Func<Entidade, bool>? getWhere();
    }
}
