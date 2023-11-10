﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using gestorOficina.Data.Context;

namespace Oficina.Dados.Migrations
{
    [DbContext(typeof(OficinaContext))]
    [Migration("20211014233824_Pessoa_Remocao_Campo_Cod_Bairro_Cidade_UF")]
    partial class Pessoa_Remocao_Campo_Cod_Bairro_Cidade_UF
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Oficina.Modelo.Classes.Pessoa.Bairro", b =>
                {
                    b.Property<string>("CodBairro")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("CodCidade")
                        .HasColumnType("text");

                    b.Property<string>("Descricao")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("cidadeCodCidade")
                        .HasColumnType("character varying(150)");

                    b.HasKey("CodBairro");

                    b.HasIndex("cidadeCodCidade");

                    b.ToTable("bairro");
                });

            modelBuilder.Entity("Oficina.Modelo.Classes.Pessoa.Cidade", b =>
                {
                    b.Property<string>("CodCidade")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("Descricao")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("UF")
                        .HasColumnType("text");

                    b.Property<string>("estadoUF")
                        .HasColumnType("character varying(3)");

                    b.HasKey("CodCidade");

                    b.HasIndex("estadoUF");

                    b.ToTable("cidade");
                });

            modelBuilder.Entity("Oficina.Modelo.Classes.Pessoa.Cliente", b =>
                {
                    b.Property<int>("CodCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CEP")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("CNPJ")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Endereco")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<string>("InscricaoMunicipal")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("Nome")
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

                    b.Property<string>("estadoUF")
                        .HasColumnType("character varying(3)");

                    b.HasKey("CodCliente");

                    b.HasIndex("bairroCodBairro");

                    b.HasIndex("cidadeCodCidade");

                    b.HasIndex("estadoUF");

                    b.ToTable("cliente");
                });

            modelBuilder.Entity("Oficina.Modelo.Classes.Pessoa.Estabelecimento", b =>
                {
                    b.Property<int>("CodEstabelecimento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CEP")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("CNPJ")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Endereco")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<string>("InscricaoMunicipal")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("NomeEstabelecimento")
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

                    b.Property<string>("estadoUF")
                        .HasColumnType("character varying(3)");

                    b.HasKey("CodEstabelecimento");

                    b.HasIndex("bairroCodBairro");

                    b.HasIndex("cidadeCodCidade");

                    b.HasIndex("estadoUF");

                    b.ToTable("estabelecimento");
                });

            modelBuilder.Entity("Oficina.Modelo.Classes.Pessoa.Estado", b =>
                {
                    b.Property<string>("UF")
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)");

                    b.Property<string>("Descricao")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.HasKey("UF");

                    b.ToTable("estado");
                });

            modelBuilder.Entity("Oficina.Modelo.Classes.Pessoa.Funcionario", b =>
                {
                    b.Property<int>("CodFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CEP")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("CNPJ")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Endereco")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<string>("InscricaoMunicipal")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("Nome")
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

                    b.Property<string>("estadoUF")
                        .HasColumnType("character varying(3)");

                    b.HasKey("CodFuncionario");

                    b.HasIndex("bairroCodBairro");

                    b.HasIndex("cidadeCodCidade");

                    b.HasIndex("estadoUF");

                    b.ToTable("funcionario");
                });

            modelBuilder.Entity("Oficina.Modelo.Classes.Pessoa.Bairro", b =>
                {
                    b.HasOne("Oficina.Modelo.Classes.Pessoa.Cidade", "cidade")
                        .WithMany()
                        .HasForeignKey("cidadeCodCidade");

                    b.Navigation("cidade");
                });

            modelBuilder.Entity("Oficina.Modelo.Classes.Pessoa.Cidade", b =>
                {
                    b.HasOne("Oficina.Modelo.Classes.Pessoa.Estado", "estado")
                        .WithMany()
                        .HasForeignKey("estadoUF");

                    b.Navigation("estado");
                });

            modelBuilder.Entity("Oficina.Modelo.Classes.Pessoa.Cliente", b =>
                {
                    b.HasOne("Oficina.Modelo.Classes.Pessoa.Bairro", "bairro")
                        .WithMany()
                        .HasForeignKey("bairroCodBairro");

                    b.HasOne("Oficina.Modelo.Classes.Pessoa.Cidade", "cidade")
                        .WithMany()
                        .HasForeignKey("cidadeCodCidade");

                    b.HasOne("Oficina.Modelo.Classes.Pessoa.Estado", "estado")
                        .WithMany()
                        .HasForeignKey("estadoUF");

                    b.Navigation("bairro");

                    b.Navigation("cidade");

                    b.Navigation("estado");
                });

            modelBuilder.Entity("Oficina.Modelo.Classes.Pessoa.Estabelecimento", b =>
                {
                    b.HasOne("Oficina.Modelo.Classes.Pessoa.Bairro", "bairro")
                        .WithMany()
                        .HasForeignKey("bairroCodBairro");

                    b.HasOne("Oficina.Modelo.Classes.Pessoa.Cidade", "cidade")
                        .WithMany()
                        .HasForeignKey("cidadeCodCidade");

                    b.HasOne("Oficina.Modelo.Classes.Pessoa.Estado", "estado")
                        .WithMany()
                        .HasForeignKey("estadoUF");

                    b.Navigation("bairro");

                    b.Navigation("cidade");

                    b.Navigation("estado");
                });

            modelBuilder.Entity("Oficina.Modelo.Classes.Pessoa.Funcionario", b =>
                {
                    b.HasOne("Oficina.Modelo.Classes.Pessoa.Bairro", "bairro")
                        .WithMany()
                        .HasForeignKey("bairroCodBairro");

                    b.HasOne("Oficina.Modelo.Classes.Pessoa.Cidade", "cidade")
                        .WithMany()
                        .HasForeignKey("cidadeCodCidade");

                    b.HasOne("Oficina.Modelo.Classes.Pessoa.Estado", "estado")
                        .WithMany()
                        .HasForeignKey("estadoUF");

                    b.Navigation("bairro");

                    b.Navigation("cidade");

                    b.Navigation("estado");
                });
#pragma warning restore 612, 618
        }
    }
}
