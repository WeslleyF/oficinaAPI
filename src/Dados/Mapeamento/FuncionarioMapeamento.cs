using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OficinaAPI.Modelo.Classes;

namespace OficinaAPI.Dados.Mapeamento
{
    class FuncionarioMapeamento : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.Property(F => F.Nome).HasMaxLength(300);
            builder.Property(F => F.InscricaoMunicipal).HasMaxLength(150);
            builder.Property(F => F.RazaoSocial).HasMaxLength(250);
            builder.Property(F => F.CEP).HasMaxLength(20);
            builder.Property(F => F.Telefone).HasMaxLength(20);
            builder.Property(F => F.Email).HasMaxLength(50);

            builder.HasKey(F => F.CodFuncionario);
        }
    }
}
