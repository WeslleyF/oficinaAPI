﻿using gestorOficina.Modelo.Interface;

namespace gestorOficina.Service
{
    public class Servico<Entidade> : IServico<Entidade> where Entidade : IEntidade
    {
        private readonly IRepositorio<Entidade> _repositorio;
        public Servico(IRepositorio<Entidade> repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<Entidade> Adicionar(Entidade instancia)
        {
            return await _repositorio.Adicionar(instancia);
        }

        public Entidade Atualizar(Entidade instancia)
        {
            return _repositorio.Atualizar(instancia);
        }

        public Task<List<Entidade>> Recuperar(Func<Entidade, bool>? where)
        {
            return _repositorio.Recuperar(null);
        }

        public Entidade Remover(Entidade instancia)
        {
            return _repositorio.Remover(instancia);
        }
    }
}