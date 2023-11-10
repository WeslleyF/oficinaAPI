using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestorOficina.Modelo.Interface;

namespace gestorOficina.Modelo.Classes
{
    public class Cidade : IEntidade
    {
        public string CodCidade { get; set; }
        public string Descricao { get; set; }
        public Estado estado { get; set; }
        public List<Bairro> bairros;
    }
}
