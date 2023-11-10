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
    class BairroMapeamento : IEntityTypeConfiguration<Bairro>
    {
        public void Configure(EntityTypeBuilder<Bairro> builder)
        {

            builder.Property(B => B.CodBairro).HasMaxLength(200);
            builder.Property(B => B.Descricao).HasMaxLength(500);

            builder.HasKey(B => B.CodBairro);

        }
    }
}
