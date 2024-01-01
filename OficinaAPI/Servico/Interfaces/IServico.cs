using OficinaAPI.Modelo.Interface;

namespace OficinaAPI.Servico.Interfaces
{
    public interface IServico<Entidade> where Entidade : IEntidade
    {
        Task<Entidade> Adicionar(Entidade instancia);
        Entidade Remover(Entidade instancia);
        Entidade Atualizar(Entidade instancia);
        List<Entidade> RecuperarTodos(Func<Entidade, bool>? where);
        Task<Entidade?> Recuperar(params object?[]? keyValues);
    }
}
