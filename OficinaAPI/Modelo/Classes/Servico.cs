using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OficinaAPI.Modelo.Interface;

namespace OficinaAPI.Modelo.Classes
{
    public class Servico : IEntidade
    {
        public int codServico { get; set; }
        public string descricao { get; set; }
        public float valor { get; set; }
        public List<NotaServicoItem>? notaServicoItens { get; set; }

        public Servico()
        {
          codServico = 0;
          descricao  = "";
          valor      = 0;
        }
    }
}
