using InvenTrack.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace InvenTrack.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Setiap DbSet merepresentasikan sebuah tabel dalam database
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Di sini Anda bisa menambahkan konfigurasi tambahan jika diperlukan,
            // seperti mendefinisikan relasi yang kompleks, indeks, dll.
            // Contoh: Membuat properti SKU unik
            modelBuilder.Entity<Item>()
                .HasIndex(i => i.SKU)
                .IsUnique();

            // Contoh: Mengkonfigurasi tipe data desimal untuk nilai unit
            modelBuilder.Entity<Item>()
                .Property(i => i.UnitValue)
                .HasColumnType("decimal(18,2)");
        }
    }
}