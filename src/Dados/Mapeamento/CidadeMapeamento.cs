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
    class CidadeMapeamento : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {

            builder.Property(C => C.CodCidade).HasMaxLength(150);
            builder.Property(C => C.Descricao).HasMaxLength(500);

            builder.HasKey(C => C.CodCidade);

        }
    }
}
