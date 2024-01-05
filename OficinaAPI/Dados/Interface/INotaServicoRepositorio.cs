using OficinaAPI.Modelo.Classes;
using OficinaAPI.Modelo.Interface;

namespace OficinaAPI.Dados.Interface
{
    public interface INotaServicoRepositorio : IRepositorio<NotaServico>
    {
        public Task<NotaServicoItem> adicionarItem(NotaServicoItem item);
        public Task<List<NotaServicoItem>> recuperarItens(int codNotaServico);
        public Task<List<NotaServico>> RecuperarComCliente();
    }
}
