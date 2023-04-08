﻿// <auto-generated />
using System;
using AgriTech.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgriTech.Migrations
{
    [DbContext(typeof(AgriTechContext))]
    partial class AgriTechContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("PlantacaoId")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PlantacaoId");

                    b.ToTable("Adubo");
                });

            modelBuilder.Entity("AgriTech.Models.Planta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ComoColher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComoGerminar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComoRegar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComoSecar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComprimentoPlantio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiasColheita")
                        .HasColumnType("int");

                    b.Property<int>("DiasGerminacao")
                        .HasColumnType("int");

                    b.Property<string>("EstacaoParaColher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstacaoParaPlantar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LarguraPlantio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCientifico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomePopular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhSolo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfundidadePlantio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TempoSecagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UmidadeSolo")
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

                    b.Property<DateTime?>("DataGerminacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataGerminou")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataPlantio")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Germinou")
                        .HasColumnType("bit");

                    b.Property<string>("Lote")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCientifico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomePlanta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlantaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlantaId");

                    b.ToTable("Plantacao");
                });

            modelBuilder.Entity("AgriTech.Models.Adubo", b =>
                {
                    b.HasOne("AgriTech.Models.Plantacao", null)
                        .WithMany("Adubo")
                        .HasForeignKey("PlantacaoId");
                });

            modelBuilder.Entity("AgriTech.Models.Plantacao", b =>
                {
                    b.HasOne("AgriTech.Models.Planta", "Planta")
                        .WithMany()
                        .HasForeignKey("PlantaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Planta");
                });

            modelBuilder.Entity("AgriTech.Models.Plantacao", b =>
                {
                    b.Navigation("Adubo");
                });
#pragma warning restore 612, 618
        }
    }
}
