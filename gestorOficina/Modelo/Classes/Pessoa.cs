using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestorOficina.Modelo.Interface;

namespace gestorOficina.Modelo.Classes
{
    public class Pessoa : IEntidade
    {
        public string CNPJ { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string RazaoSocial { get; set; }
        public string CEP { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Logradouro { get; set; }
        public Bairro bairro { get; set; }
        public Cidade cidade { get; set; }
        public Estado estado { get; set; }
        public string numero { get; set; }
    }
}
