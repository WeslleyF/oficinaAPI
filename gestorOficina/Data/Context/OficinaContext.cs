using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using gestorOficina.Modelo.Classes;
using gestorOficina.Modelo.Interface;

namespace gestorOficina.Data.Context
{
    public class OficinaContext : DbContext
    {
        public OficinaContext(DbContextOptions<OficinaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OficinaContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Estabelecimento> estabelecimento { get; set; }
        public DbSet<Estado> estado { get; set; }
        public DbSet<Cidade> cidade { get; set; }
        public DbSet<Bairro> bairro { get; set; }
        public DbSet<Funcionario> funcionario { get; set; }
        public DbSet<Endereco> endereco { get; set; }

    }
}
