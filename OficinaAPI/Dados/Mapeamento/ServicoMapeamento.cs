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
    class ServicoMapeamento : IEntityTypeConfiguration<OficinaAPI.Modelo.Classes.Servico>
    {
        public void Configure(EntityTypeBuilder<OficinaAPI.Modelo.Classes.Servico> builder)
        {
            builder.Property(S => S.descricao).HasMaxLength(150);

            builder.HasKey(S => S.codServico);
        }
    }
}
