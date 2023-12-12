using OficinaAPI.Modelo.Interface;

namespace OficinaAPI.Dados.Interface
{
    public interface IRepositorio<Entidade> where Entidade : IEntidade
    {
        Task<Entidade> Adicionar(Entidade instancia);
        Entidade Remover(Entidade instancia);
        Entidade Atualizar(Entidade instancia);
        List<Entidade> Recuperar(Func<Entidade, bool>? where);
        Task<Entidade?> Recuperar(params object?[]? keyValues);
    }
}
