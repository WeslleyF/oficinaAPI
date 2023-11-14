using OficinaAPI.Modelo.Interface;

namespace OficinaAPI.Servico.Interfaces
{
    public interface IServico<Entidade> where Entidade : IEntidade
    {
        Task<Entidade> Adicionar(Entidade instancia);
        Entidade Remover(Entidade instancia);
        Entidade Atualizar(Entidade instancia);
        Task<List<Entidade>> Recuperar(Func<Entidade, bool>? where);
    }
}
