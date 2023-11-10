using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestorOficina.Modelo.Interface;

namespace gestorOficina.Modelo.Classes

{
    public class Bairro : IEntidade
    {
        public string CodBairro { get; set; }
        public string Descricao { get; set; }
        public string CodCidade { get; set; }
        public Cidade cidade { get; set; }
    }
}
