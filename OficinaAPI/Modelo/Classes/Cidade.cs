﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OficinaAPI.Modelo.Interface;

namespace OficinaAPI.Modelo.Classes
{
    public class Cidade : IEntidade
    {
        public string CodCidade { get; set; }
        public string Descricao { get; set; }
        public Estado estado { get; set; }
        public string UF { get; set; }
        public List<Bairro> bairros;
    }
}
