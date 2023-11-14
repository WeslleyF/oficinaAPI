using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaAPI.Modelo.Classes
{
    public class Cliente : Pessoa
    {
        public int CodCliente { get; set; }
        public string Nome { get; set; }
    }
}
