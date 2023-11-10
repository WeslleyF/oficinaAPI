using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestorOficina.Modelo.Interface;

namespace gestorOficina.Modelo.Classes
{
    public class Estado : IEntidade
    {
        public string UF { get; set; }
        public string Descricao { get; set; }
        public List<Cidade> cidades;
    }
}
