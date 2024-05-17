using Microsoft.EntityFrameworkCore;
using MyRazorApp.Models;  // Model sınıflarınızın olduğu namespace'i ekleyin

namespace MyRazorApp.Data
{
    public class Ceng382Context : DbContext
    {
        public Ceng382Context(DbContextOptions<Ceng382Context> options) : base(options)
        {
        }

        // Burada veritabanı tablolarını temsil eden DbSets ekleyebilirsiniz
        public DbSet<Reservation> Reservations { get; set; }
    }
}
