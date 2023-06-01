using Microsoft.EntityFrameworkCore;
using ProjetoCinema.Models;
using System.Configuration;

namespace ProjetoCinema.Data
{
    public class CinemaDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>        
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["CinemaDb"].ConnectionString);
        

    }
}