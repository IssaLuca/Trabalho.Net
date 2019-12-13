﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrabalhoLUCAISSA.Models;

namespace TrabalhoLUCAISSA.Migrations
{
    [DbContext(typeof(TrabalhoLUCAISSAContext))]
    [Migration("20191213193252_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TrabalhoLUCAISSA.Models.Jogador", b =>
                {
                    b.Property<int>("JogadorID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Idade");

                    b.Property<string>("Nacionalidade");

                    b.Property<string>("Nome");

                    b.HasKey("JogadorID");

                    b.ToTable("Jogador");
                });

            modelBuilder.Entity("TrabalhoLUCAISSA.Models.Placar", b =>
                {
                    b.Property<int>("PlacarID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data");

                    b.Property<int>("JogadorID");

                    b.Property<int>("Pontuacao");

                    b.HasKey("PlacarID");

                    b.HasIndex("JogadorID");

                    b.ToTable("Placar");
                });

            modelBuilder.Entity("TrabalhoLUCAISSA.Models.Placar", b =>
                {
                    b.HasOne("TrabalhoLUCAISSA.Models.Jogador", "Jogador")
                        .WithMany()
                        .HasForeignKey("JogadorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
