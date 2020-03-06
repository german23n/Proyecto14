﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto14.models;

namespace Proyecto14.Migrations
{
    [DbContext(typeof(ApplicationDbcontext))]
    [Migration("20200306085357_initialCreate1")]
    partial class initialCreate1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proyecto14.models.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCategoria");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Proyecto14.models.categoriaSubcategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoriaIdCategoria")
                        .HasColumnType("int");

                    b.Property<int>("IdCategoria")
                        .HasColumnType("int");

                    b.Property<int>("IdSubCategoria")
                        .HasColumnType("int");

                    b.Property<int?>("SubCategoriaIdSubCategoria")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaIdCategoria");

                    b.HasIndex("SubCategoriaIdSubCategoria");

                    b.ToTable("CategoriaSubCategorias");
                });

            modelBuilder.Entity("Proyecto14.models.subCategoria", b =>
                {
                    b.Property<int>("IdSubCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdSubCategoria");

                    b.ToTable("SubCategorias");
                });

            modelBuilder.Entity("Proyecto14.models.categoriaSubcategoria", b =>
                {
                    b.HasOne("Proyecto14.models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaIdCategoria");

                    b.HasOne("Proyecto14.models.subCategoria", "SubCategoria")
                        .WithMany("CategoriaSubCategorias")
                        .HasForeignKey("SubCategoriaIdSubCategoria");
                });
#pragma warning restore 612, 618
        }
    }
}
