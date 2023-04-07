﻿// <auto-generated />
using System;
using AgriTech.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgriTech.Migrations
{
    [DbContext(typeof(AgriTechContext))]
    [Migration("20230407200005_Atualizacao8")]
    partial class Atualizacao8
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AgriTech.Models.Adubo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DescricaoMontagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescricaoUso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredientes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Adubo");
                });

            modelBuilder.Entity("AgriTech.Models.Planta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ComoColher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComoGerminar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComoRegar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComoSecar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComprimentoPlantio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiasColheita")
                        .HasColumnType("int");

                    b.Property<int>("DiasGerminacao")
                        .HasColumnType("int");

                    b.Property<string>("EstacaoParaColher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstacaoParaPlantar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LarguraPlantio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCientifico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomePopular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacoes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhSolo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfundidadePlantio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TempoSecagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UmidadeSolo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Planta");
                });

            modelBuilder.Entity("AgriTech.Models.Plantacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AduboId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataColheita")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataGerminacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataGerminou")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataPlantio")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Germinou")
                        .HasColumnType("bit");

                    b.Property<string>("Lote")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeAdubo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCientifico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomePlanta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlantaId")
                        .HasColumnType("int");

                    b.Property<string>("TipoAdubo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AduboId");

                    b.HasIndex("PlantaId");

                    b.ToTable("Plantacao");
                });

            modelBuilder.Entity("AgriTech.Models.Plantacao", b =>
                {
                    b.HasOne("AgriTech.Models.Adubo", "Adubo")
                        .WithMany()
                        .HasForeignKey("AduboId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AgriTech.Models.Planta", "Planta")
                        .WithMany()
                        .HasForeignKey("PlantaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adubo");

                    b.Navigation("Planta");
                });
#pragma warning restore 612, 618
        }
    }
}
