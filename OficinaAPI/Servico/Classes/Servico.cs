using OficinaAPI.Dados.Interface;
using OficinaAPI.Modelo.Interface;
using OficinaAPI.Servico.Interfaces;

namespace OficinaAPI.Servico.Classes
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

        public List<Entidade> Recuperar(Func<Entidade, bool>? where)
        {
            return _repositorio.Recuperar(where);
        }

        public Task<Entidade?> Recuperar(params object?[]? keyValues)
        {
            return _repositorio.Recuperar(keyValues);
        }

        public Entidade Remover(Entidade instancia)
        {
            return _repositorio.Remover(instancia);
        }
    }
}
