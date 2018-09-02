using Microsoft.EntityFrameworkCore;
using ProjetoBanca.Models;
using System;

namespace ProjetoBanca.DAO
{
    public class PetContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssllocaldb;Database=PeDB;Trusted_Connection=true;");
        }
    }
}