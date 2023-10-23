﻿// <auto-generated />
using System;
using DailyManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DailyManagment.Migrations
{
    [DbContext(typeof(DailyContext))]
    [Migration("20231023112049_changePropertiosOfModelDaily")]
    partial class changePropertiosOfModelDaily
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("DailyManagment.Models.Daily", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnaliseCredito")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CRM")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cliente")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataAprovacao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataDefinicao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataEntregaPrevista")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataEntregaReal")
                        .HasColumnType("TEXT");

                    b.Property<string>("PV")
                        .HasColumnType("TEXT");

                    b.Property<string>("Pendencia")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Projeto_Aplicacao")
                        .HasColumnType("TEXT");

                    b.Property<int>("ResponsavelId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Rev")
                        .HasColumnType("TEXT");

                    b.Property<int>("SegmentoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TipoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("ResponsavelId");

                    b.HasIndex("SegmentoId");

                    b.HasIndex("TipoId");

                    b.ToTable("Dailies");
                });

            modelBuilder.Entity("DailyManagment.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("DailyManagment.Models.Responsavel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Responsavel");
                });

            modelBuilder.Entity("DailyManagment.Models.Segmento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Segmento");
                });

            modelBuilder.Entity("DailyManagment.Models.Tipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tipo");
                });

            modelBuilder.Entity("DailyManagment.Models.Daily", b =>
                {
                    b.HasOne("DailyManagment.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DailyManagment.Models.Responsavel", "Responsavel")
                        .WithMany()
                        .HasForeignKey("ResponsavelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DailyManagment.Models.Segmento", "Segmento")
                        .WithMany()
                        .HasForeignKey("SegmentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DailyManagment.Models.Tipo", "Tipo")
                        .WithMany()
                        .HasForeignKey("TipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");

                    b.Navigation("Responsavel");

                    b.Navigation("Segmento");

                    b.Navigation("Tipo");
                });
#pragma warning restore 612, 618
        }
    }
}