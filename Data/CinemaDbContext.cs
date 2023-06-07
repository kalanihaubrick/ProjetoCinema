using Microsoft.EntityFrameworkCore;
using ProjetoCinema.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;

namespace ProjetoCinema.Data
{
    public class CinemaDbContext : DbContext
    {
        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Assento> assento { get; set; }
        public DbSet<Sala> sala { get; set; }
        public DbSet<Filme> filme { get; set; }
        public DbSet<Reserva> reserva { get; set; }
        public DbSet<Sessao> sessao { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>        
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["CinemaDb"].ConnectionString);
    }
}