using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_rest.Domain.Models;
using Microsoft.EntityFrameworkCore;
using SuperMercado.API.Domain;

namespace api_rest.Persistencia
{
    public class AppDbContext : DbContext
    {
        public DbSet<Categoria> Categorias{get; set;}

        public DbSet<Produto> Produtos{get; set;}

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder builder){

          base.OnModelCreating(builder);

            builder.Entity<Categoria>().ToTable("Categorias");
            builder.Entity<Categoria>().HasKey(p => p.Id);
            builder.Entity<Categoria>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Categoria>().Property(p => p.Nome).IsRequired().HasMaxLength(30);
            builder.Entity<Categoria>().HasMany(p => p.Produtos).WithOne(p => p.Categoria).HasForeignKey(p => p.CategoriaId);

            builder.Entity<Categoria>().HasData(
                new Categoria {Id = 100, Nome = "Frutas e Vegetais"},
                new Categoria {Id = 101, Nome = "Laticínos" }
            );

            builder.Entity<Produto>().ToTable("Produto");
            builder.Entity<Produto>().HasKey(p => p.Id);
            builder.Entity<Produto>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Produto>().Property(p => p.Nome).IsRequired().HasMaxLength(50);
            builder.Entity<Produto>().Property(p => p.QuantidadeNoPacote).IsRequired();
            builder.Entity<Produto>().Property(p => p.UnitOfMeasurement).IsRequired();
            
        }
    }
}