using System;

namespace InvenTrack.Api.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? SKU { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public int MinimumQuantity { get; set; }
        public decimal UnitValue { get; set; }
        public string? Supplier { get; set; }
        public DateTime LastUpdated { get; set; }

        // Kunci asing (Foreign Key) ke tabel Category
        public int CategoryId { get; set; }
        // Properti navigasi ke Category
        public Category? Category { get; set; }

        // Kunci asing (Foreign Key) ke tabel Location
        public int LocationId { get; set; }
        // Properti navigasi ke Location
        public Location? Location { get; set; }

        // Properti navigasi untuk semua transaksi yang terkait dengan item ini
        public ICollection<Transaction>? Transactions { get; set; }
    }
}