using FarmaciaAPI.DTOS;
using FarmaciaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FarmaciaAPI.Context;

public class FContext : DbContext
{
    public FContext(DbContextOptions<FContext> options) : base(options) { }

 

    public DbSet<Produtos> Produtos { get; set; }
    public DbSet<Imagem> Imagens { get; set; }

}

/*
 *  protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Imagem>()
            .HasKey(imagem => new { imagem.ProdutoId, imagem.ImagemURL });
    }
 protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Imagem>()
            .HasKey(imagem => new { imagem.ProdutoId, imagem.ImagemURL });
    }
 * 
*/