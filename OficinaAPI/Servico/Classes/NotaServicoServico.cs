using OficinaAPI.Dados.Interface;
using OficinaAPI.Dados.Classes;
using OficinaAPI.Modelo.Classes;
using OficinaAPI.Modelo.Interface;
using OficinaAPI.Servico.Interfaces;

namespace OficinaAPI.Servico.Classes
{
    public class NotaServicoServico : Servico<NotaServico>, INotaServicoServico
    {
        public NotaServicoServico(INotaServicoRepositorio repositorio) : base(repositorio)
        {
            
        }
    }
}
