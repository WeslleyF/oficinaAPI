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
    class NotaServicoItemMapeamento : IEntityTypeConfiguration<NotaServicoItem>
    {
        public void Configure(EntityTypeBuilder<NotaServicoItem> builder)
        {           
            builder.HasKey(NSI => NSI.codNotaServicoItem);

            builder.HasOne(NSI => NSI.servico).WithMany(s => s.notaServicoItens).HasForeignKey(NSI => NSI.codServico);
            builder.HasOne(NSI => NSI.notaServico).WithMany(NS => NS.itens).HasForeignKey(NSI => NSI.codNotaServico);
        }
    }
}
