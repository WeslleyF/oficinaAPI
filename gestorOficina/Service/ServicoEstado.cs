using gestorOficina.Modelo.Classes;
using gestorOficina.Modelo.Interface;

namespace gestorOficina.Service
{
    public class ServicoEstado : Servico<Estado>
    {
        public ServicoEstado(IRepositorio<Estado> repositorio) : base(repositorio)
        {
        }
    }
}
