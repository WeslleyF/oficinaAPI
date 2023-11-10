using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestorOficina.Modelo.Interface;

namespace gestorOficina.Modelo.Classes
{
    public class Endereco : IEntidade
    {
        public int CodCliente { get; set; }
        public Cliente cliente { get; set; }

        public string Logradouro { get; set; }
        public Bairro bairro { get; set; }
        public Cidade cidade { get; set; }
        public Estado estado { get; set; }
    }
}
