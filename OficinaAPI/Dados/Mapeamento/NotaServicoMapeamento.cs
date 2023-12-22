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
    class NotaServicoMapeamento : IEntityTypeConfiguration<NotaServico>
    {
        public void Configure(EntityTypeBuilder<NotaServico> builder)
        {           
            builder.HasKey(NS => NS.codNotaServico);
            builder.HasOne(NS => NS.cliente).WithMany(C => C.notas).HasForeignKey(NS => NS.codCliente);
        }
    }
}
