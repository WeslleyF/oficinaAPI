﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OficinaAPI.Modelo.Classes;

namespace OficinaAPI.Dados.Mapeamento
{
    class BairroMapeamento : IEntityTypeConfiguration<Bairro>
    {
        public void Configure(EntityTypeBuilder<Bairro> builder)
        {

            builder.Property(B => B.CodBairro).HasMaxLength(200);
            builder.Property(B => B.Descricao).HasMaxLength(500);
            builder.HasOne(B => B.cidade).WithMany(C => C.bairros).HasForeignKey(B => B.CodCidade);

            builder.HasKey(B => B.CodBairro);

        }
    }
}
