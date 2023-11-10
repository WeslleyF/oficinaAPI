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
        public Endereco endereco { get; set; }
    }
}
