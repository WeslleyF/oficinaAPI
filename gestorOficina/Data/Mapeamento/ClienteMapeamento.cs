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
    class ClienteMapeamento : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {

            builder.Property(C => C.Nome).HasMaxLength(300);
            builder.Property(C => C.InscricaoMunicipal).HasMaxLength(150);
            builder.Property(C => C.RazaoSocial).HasMaxLength(250);
            builder.Property(C => C.CEP).HasMaxLength(20);
            builder.Property(C => C.Telefone).HasMaxLength(20);
            builder.Property(C => C.Email).HasMaxLength(50);
            builder.Property(C => C.numero).HasMaxLength(10);

            builder.HasKey(C => C.CodCliente);
        }
    }
}
