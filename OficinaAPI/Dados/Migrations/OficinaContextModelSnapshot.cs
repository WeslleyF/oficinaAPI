﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OficinaAPI.Dados.Context;

#nullable disable

namespace OficinaAPI.Dados.Migrations
{
    [DbContext(typeof(OficinaContext))]
    partial class OficinaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.Bairro", b =>
                {
                    b.Property<string>("CodBairro")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("cidadeCodCidade")
                        .IsRequired()
                        .HasColumnType("character varying(150)");

                    b.HasKey("CodBairro");

                    b.HasIndex("cidadeCodCidade");

                    b.ToTable("bairro");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.Cidade", b =>
                {
                    b.Property<string>("CodCidade")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("estadoUF")
                        .IsRequired()
                        .HasColumnType("character varying(3)");

                    b.HasKey("CodCidade");

                    b.HasIndex("estadoUF");

                    b.ToTable("cidade");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.Cliente", b =>
                {
                    b.Property<int>("CodCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CodCliente"));

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("InscricaoMunicipal")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("bairroCodBairro")
                        .IsRequired()
                        .HasColumnType("character varying(200)");

                    b.Property<string>("cidadeCodCidade")
                        .IsRequired()
                        .HasColumnType("character varying(150)");

                    b.Property<string>("estadoUF")
                        .IsRequired()
                        .HasColumnType("character varying(3)");

                    b.Property<string>("numero")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.HasKey("CodCliente");

                    b.HasIndex("bairroCodBairro");

                    b.HasIndex("cidadeCodCidade");

                    b.HasIndex("estadoUF");

                    b.ToTable("cliente");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.Estabelecimento", b =>
                {
                    b.Property<int>("CodEstabelecimento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CodEstabelecimento"));

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("InscricaoMunicipal")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NomeEstabelecimento")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("bairroCodBairro")
                        .IsRequired()
                        .HasColumnType("character varying(200)");

                    b.Property<string>("cidadeCodCidade")
                        .IsRequired()
                        .HasColumnType("character varying(150)");

                    b.Property<string>("estadoUF")
                        .IsRequired()
                        .HasColumnType("character varying(3)");

                    b.Property<string>("numero")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CodEstabelecimento");

                    b.HasIndex("bairroCodBairro");

                    b.HasIndex("cidadeCodCidade");

                    b.HasIndex("estadoUF");

                    b.ToTable("estabelecimento");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.Estado", b =>
                {
                    b.Property<string>("UF")
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.HasKey("UF");

                    b.ToTable("estado");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.Funcionario", b =>
                {
                    b.Property<int>("CodFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CodFuncionario"));

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("InscricaoMunicipal")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("bairroCodBairro")
                        .IsRequired()
                        .HasColumnType("character varying(200)");

                    b.Property<string>("cidadeCodCidade")
                        .IsRequired()
                        .HasColumnType("character varying(150)");

                    b.Property<string>("estadoUF")
                        .IsRequired()
                        .HasColumnType("character varying(3)");

                    b.Property<string>("numero")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CodFuncionario");

                    b.HasIndex("bairroCodBairro");

                    b.HasIndex("cidadeCodCidade");

                    b.HasIndex("estadoUF");

                    b.ToTable("funcionario");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.Bairro", b =>
                {
                    b.HasOne("OficinaAPI.Modelo.Classes.Cidade", "cidade")
                        .WithMany()
                        .HasForeignKey("cidadeCodCidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cidade");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.Cidade", b =>
                {
                    b.HasOne("OficinaAPI.Modelo.Classes.Estado", "estado")
                        .WithMany()
                        .HasForeignKey("estadoUF")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("estado");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.Cliente", b =>
                {
                    b.HasOne("OficinaAPI.Modelo.Classes.Bairro", "bairro")
                        .WithMany()
                        .HasForeignKey("bairroCodBairro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OficinaAPI.Modelo.Classes.Cidade", "cidade")
                        .WithMany()
                        .HasForeignKey("cidadeCodCidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OficinaAPI.Modelo.Classes.Estado", "estado")
                        .WithMany()
                        .HasForeignKey("estadoUF")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bairro");

                    b.Navigation("cidade");

                    b.Navigation("estado");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.Estabelecimento", b =>
                {
                    b.HasOne("OficinaAPI.Modelo.Classes.Bairro", "bairro")
                        .WithMany()
                        .HasForeignKey("bairroCodBairro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OficinaAPI.Modelo.Classes.Cidade", "cidade")
                        .WithMany()
                        .HasForeignKey("cidadeCodCidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OficinaAPI.Modelo.Classes.Estado", "estado")
                        .WithMany()
                        .HasForeignKey("estadoUF")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bairro");

                    b.Navigation("cidade");

                    b.Navigation("estado");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.Funcionario", b =>
                {
                    b.HasOne("OficinaAPI.Modelo.Classes.Bairro", "bairro")
                        .WithMany()
                        .HasForeignKey("bairroCodBairro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OficinaAPI.Modelo.Classes.Cidade", "cidade")
                        .WithMany()
                        .HasForeignKey("cidadeCodCidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OficinaAPI.Modelo.Classes.Estado", "estado")
                        .WithMany()
                        .HasForeignKey("estadoUF")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bairro");

                    b.Navigation("cidade");

                    b.Navigation("estado");
                });
#pragma warning restore 612, 618
        }
    }
}
