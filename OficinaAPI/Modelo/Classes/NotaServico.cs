using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OficinaAPI.Modelo.Interface;

namespace OficinaAPI.Modelo.Classes
{
    public class NotaServico : IEntidade
    {
        public int codNotaServico { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataPrestacao { get; set; }
        public float valor { get; set; }
        public List<NotaServicoItem>? itens { get; set; }
        public int codCliente { get; set; }
        public Cliente? cliente { get; set; }
    }
}
