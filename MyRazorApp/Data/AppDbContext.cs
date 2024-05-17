using Microsoft.EntityFrameworkCore;
using MyRazorApp.Models;  // Model sınıflarınızın olduğu namespace'i ekleyin

namespace MyRazorApp.Data
{
    public class Ceng382Context : DbContext
    {
        public Ceng382Context()
        {
        }

        public Ceng382Context(DbContextOptions<Ceng382Context> options) : base(options)
        {
        }

        // Burada veritabanı tablolarını temsil eden DbSets ekleyebilirsiniz
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Room { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
