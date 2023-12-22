﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OficinaAPI.Dados.Context;

#nullable disable

namespace OficinaAPI.Dados.Migrations
{
    [DbContext(typeof(OficinaContext))]
    [Migration("20231222024925_vinc_NS_cliente")]
    partial class vinc_NS_cliente
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("CodCidade")
                        .IsRequired()
                        .HasColumnType("character varying(150)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.HasKey("CodBairro");

                    b.HasIndex("CodCidade");

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

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("character varying(3)");

                    b.HasKey("CodCidade");

                    b.HasIndex("UF");

                    b.ToTable("cidade");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.Cliente", b =>
                {
                    b.Property<int>("CodCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CodCliente"));

                    b.Property<string>("CEP")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("CNPJ")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("CPF")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("InscricaoMunicipal")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("Logradouro")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<string>("RazaoSocial")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("Telefone")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("codBairro")
                        .HasColumnType("character varying(200)");

                    b.Property<string>("codCidade")
                        .HasColumnType("character varying(150)");

                    b.Property<string>("numero")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("uf")
                        .HasColumnType("character varying(3)");

                    b.HasKey("CodCliente");

                    b.HasIndex("codBairro");

                    b.HasIndex("codCidade");

                    b.HasIndex("uf");

                    b.ToTable("cliente");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.Estabelecimento", b =>
                {
                    b.Property<int>("CodEstabelecimento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CodEstabelecimento"));

                    b.Property<string>("CEP")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("CNPJ")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("InscricaoMunicipal")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("text");

                    b.Property<string>("NomeEstabelecimento")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<string>("RazaoSocial")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("Telefone")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("bairroCodBairro")
                        .HasColumnType("character varying(200)");

                    b.Property<string>("cidadeCodCidade")
                        .HasColumnType("character varying(150)");

                    b.Property<string>("codBairro")
                        .HasColumnType("text");

                    b.Property<string>("codCidade")
                        .HasColumnType("text");

                    b.Property<string>("estadoUF")
                        .HasColumnType("character varying(3)");

                    b.Property<string>("numero")
                        .HasColumnType("text");

                    b.Property<string>("uf")
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
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("CNPJ")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("InscricaoMunicipal")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<string>("RazaoSocial")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("Telefone")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("bairroCodBairro")
                        .HasColumnType("character varying(200)");

                    b.Property<string>("cidadeCodCidade")
                        .HasColumnType("character varying(150)");

                    b.Property<string>("codBairro")
                        .HasColumnType("text");

                    b.Property<string>("codCidade")
                        .HasColumnType("text");

                    b.Property<string>("estadoUF")
                        .HasColumnType("character varying(3)");

                    b.Property<string>("numero")
                        .HasColumnType("text");

                    b.Property<string>("uf")
                        .HasColumnType("text");

                    b.HasKey("CodFuncionario");

                    b.HasIndex("bairroCodBairro");

                    b.HasIndex("cidadeCodCidade");

                    b.HasIndex("estadoUF");

                    b.ToTable("funcionario");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.NotaServico", b =>
                {
                    b.Property<int>("codNotaServico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("codNotaServico"));

                    b.Property<int>("codCliente")
                        .HasColumnType("integer");

                    b.Property<DateTime>("dataCadastro")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("dataPrestacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<float>("valor")
                        .HasColumnType("real");

                    b.HasKey("codNotaServico");

                    b.HasIndex("codCliente");

                    b.ToTable("notaServico");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.NotaServicoItem", b =>
                {
                    b.Property<int>("codNotaServicoItem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("codNotaServicoItem"));

                    b.Property<int>("codNotaServico")
                        .HasColumnType("integer");

                    b.Property<int>("codServico")
                        .HasColumnType("integer");

                    b.Property<float>("qtd")
                        .HasColumnType("real");

                    b.Property<float>("valor")
                        .HasColumnType("real");

                    b.Property<float>("valorTotal")
                        .HasColumnType("real");

                    b.HasKey("codNotaServicoItem");

                    b.HasIndex("codNotaServico");

                    b.HasIndex("codServico");

                    b.ToTable("notaServicoItem");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.Servico", b =>
                {
                    b.Property<int>("codServico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("codServico"));

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<float>("valor")
                        .HasColumnType("real");

                    b.HasKey("codServico");

                    b.ToTable("servico");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.Bairro", b =>
                {
                    b.HasOne("OficinaAPI.Modelo.Classes.Cidade", "cidade")
                        .WithMany("bairros")
                        .HasForeignKey("CodCidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cidade");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.Cidade", b =>
                {
                    b.HasOne("OficinaAPI.Modelo.Classes.Estado", "estado")
                        .WithMany("cidades")
                        .HasForeignKey("UF")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("estado");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.Cliente", b =>
                {
                    b.HasOne("OficinaAPI.Modelo.Classes.Bairro", "bairro")
                        .WithMany()
                        .HasForeignKey("codBairro");

                    b.HasOne("OficinaAPI.Modelo.Classes.Cidade", "cidade")
                        .WithMany()
                        .HasForeignKey("codCidade");

                    b.HasOne("OficinaAPI.Modelo.Classes.Estado", "estado")
                        .WithMany()
                        .HasForeignKey("uf");

                    b.Navigation("bairro");

                    b.Navigation("cidade");

                    b.Navigation("estado");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.Estabelecimento", b =>
                {
                    b.HasOne("OficinaAPI.Modelo.Classes.Bairro", "bairro")
                        .WithMany()
                        .HasForeignKey("bairroCodBairro");

                    b.HasOne("OficinaAPI.Modelo.Classes.Cidade", "cidade")
                        .WithMany()
                        .HasForeignKey("cidadeCodCidade");

                    b.HasOne("OficinaAPI.Modelo.Classes.Estado", "estado")
                        .WithMany()
                        .HasForeignKey("estadoUF");

                    b.Navigation("bairro");

                    b.Navigation("cidade");

                    b.Navigation("estado");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.Funcionario", b =>
                {
                    b.HasOne("OficinaAPI.Modelo.Classes.Bairro", "bairro")
                        .WithMany()
                        .HasForeignKey("bairroCodBairro");

                    b.HasOne("OficinaAPI.Modelo.Classes.Cidade", "cidade")
                        .WithMany()
                        .HasForeignKey("cidadeCodCidade");

                    b.HasOne("OficinaAPI.Modelo.Classes.Estado", "estado")
                        .WithMany()
                        .HasForeignKey("estadoUF");

                    b.Navigation("bairro");

                    b.Navigation("cidade");

                    b.Navigation("estado");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.NotaServico", b =>
                {
                    b.HasOne("OficinaAPI.Modelo.Classes.Cliente", "cliente")
                        .WithMany("notas")
                        .HasForeignKey("codCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cliente");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.NotaServicoItem", b =>
                {
                    b.HasOne("OficinaAPI.Modelo.Classes.NotaServico", "notaServico")
                        .WithMany("itens")
                        .HasForeignKey("codNotaServico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OficinaAPI.Modelo.Classes.Servico", "servico")
                        .WithMany("notaServicoItens")
                        .HasForeignKey("codServico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("notaServico");

                    b.Navigation("servico");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.Cidade", b =>
                {
                    b.Navigation("bairros");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.Cliente", b =>
                {
                    b.Navigation("notas");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.Estado", b =>
                {
                    b.Navigation("cidades");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.NotaServico", b =>
                {
                    b.Navigation("itens");
                });

            modelBuilder.Entity("OficinaAPI.Modelo.Classes.Servico", b =>
                {
                    b.Navigation("notaServicoItens");
                });
#pragma warning restore 612, 618
        }
    }
}
