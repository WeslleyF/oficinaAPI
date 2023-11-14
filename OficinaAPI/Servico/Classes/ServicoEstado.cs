using OficinaAPI.Dados.Interface;
using OficinaAPI.Modelo.Classes;

namespace OficinaAPI.Servico.Classes
{
    public class ServicoEstado : Servico<Estado>
    {
        public ServicoEstado(IRepositorio<Estado> repositorio) : base(repositorio)
        {
        }
    }
}
