using Microsoft.EntityFrameworkCore;
namespace MauriDb.Models
{
    public class MauriDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
             => options.UseSqlite("Data Source=database.db");

        public DbSet<Prenotazione> Prenotazioni { get ; set; }
    }
}