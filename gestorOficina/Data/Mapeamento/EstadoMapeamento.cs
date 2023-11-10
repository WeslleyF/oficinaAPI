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
    class EstadoMapeamento : IEntityTypeConfiguration<Estado>
    {

        public void Configure(EntityTypeBuilder<Estado> builder)
        {

            builder.Property(E => E.UF).HasMaxLength(3);
            builder.Property(E => E.Descricao).HasMaxLength(250);

            builder.HasKey(E => E.UF);

        }


    }
}
