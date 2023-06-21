﻿// <auto-generated />
using FarmaciaAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FarmaciaAPI.Migrations
{
    [DbContext(typeof(FContext))]
    [Migration("20230618155220_Blob Image Relacionamento3")]
    partial class BlobImageRelacionamento3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FarmaciaAPI.Models.Imagem", b =>
                {
                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<string>("ImagemURL")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ProdutoId", "ImagemURL");

                    b.ToTable("Imagens");
                });

            modelBuilder.Entity("FarmaciaAPI.Models.Produtos", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProdutoId"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProdutoId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("FarmaciaAPI.Models.Imagem", b =>
                {
                    b.HasOne("FarmaciaAPI.Models.Produtos", "Produto")
                        .WithMany("Imagens")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("FarmaciaAPI.Models.Produtos", b =>
                {
                    b.Navigation("Imagens");
                });
#pragma warning restore 612, 618
        }
    }
}
