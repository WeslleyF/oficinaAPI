using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OficinaAPI.Modelo.Interface;

namespace OficinaAPI.Modelo.Classes
{
    public class NotaServicoItem : IEntidade
    {
        public int codNotaServicoItem { get; set; }
        public int codNotaServico { get; set; }
        public NotaServico notaServico { get; set; }
        public int codServico { get; set; }
        public OficinaAPI.Modelo.Classes.Servico? servico { get; set; }
        public float valor { get; set; }
        public float qtd { get; set; }
        public float valorTotal { get; set; }
    }
}
