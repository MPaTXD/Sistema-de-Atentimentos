﻿// <auto-generated />
using System;
using Infrastructure.Configs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ContextBase))]
    [Migration("20211014172844_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entites.Entites.Atendimento", b =>
                {
                    b.Property<int>("IdAtendimento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataDeConclusao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeLancamento")
                        .HasColumnType("datetime2");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<int>("OrdemId")
                        .HasColumnType("int");

                    b.Property<long>("Protocolo")
                        .HasColumnType("bigint");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("IdAtendimento");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("OrdemId");

                    b.ToTable("Atendimento");
                });

            modelBuilder.Entity("Entites.Entites.Funcionario", b =>
                {
                    b.Property<int>("IdFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Atendimento")
                        .HasColumnType("int");

                    b.Property<long>("Matricula")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdFuncionario");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("Entites.Entites.Ordem", b =>
                {
                    b.Property<int>("IdOrdem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Atendimento")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDeConclusao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeLancamento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Solicitante")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdOrdem");

                    b.ToTable("Ordem");
                });

            modelBuilder.Entity("Entites.Entites.Atendimento", b =>
                {
                    b.HasOne("Entites.Entites.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entites.Entites.Ordem", "Ordem")
                        .WithMany()
                        .HasForeignKey("OrdemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");

                    b.Navigation("Ordem");
                });
#pragma warning restore 612, 618
        }
    }
}