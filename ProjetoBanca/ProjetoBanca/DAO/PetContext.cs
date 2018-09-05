using Microsoft.EntityFrameworkCore;
using ProjetoBanca.Models;
using System;

namespace ProjetoBanca.DAO
{
    public class PetContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Estoque> Estoques { get; set; }

        public DbSet<Produtos> Produtos { get; set; }

        public DbSet<UnidadeMedida> UnidadeMedidas { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PetDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

    }
}