using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using gestorOficina.Modelo.Classes;

namespace gestorOficina.Data.Mapeamento
{
    class EstabelecimentoMapeamento : IEntityTypeConfiguration<Estabelecimento>
    {
        public void Configure(EntityTypeBuilder<Estabelecimento> builder)
        {

            builder.Property(E => E.NomeEstabelecimento).HasMaxLength(300);
            builder.Property(E => E.InscricaoMunicipal).HasMaxLength(150);
            builder.Property(E => E.RazaoSocial).HasMaxLength(250);
            builder.Property(E => E.CEP).HasMaxLength(20);
            builder.Property(E => E.Telefone).HasMaxLength(20);
            builder.Property(E => E.Email).HasMaxLength(50);

            builder.HasKey(E => E.CodEstabelecimento);

        }
    }
}
