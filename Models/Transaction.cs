using System;

namespace InvenTrack.Api.Models
{
    public enum TransactionType
    {
        StockIn,
        StockOut,
        Adjustment
    }

    public class Transaction
    {
        public int Id { get; set; }
        public TransactionType Type { get; set; }
        public int QuantityChange { get; set; } // Perubahan kuantitas (+5, -2, dll.)
        public string? Notes { get; set; }
        public string? Reference { get; set; }
        public DateTime Timestamp { get; set; }

        // Kunci asing (Foreign Key) ke tabel Item
        public int ItemId { get; set; }
        // Properti navigasi ke Item
        public Item? Item { get; set; }

        // Kunci asing (Foreign Key) ke tabel User
        public int UserId { get; set; }
        // Properti navigasi ke User
        public User? User { get; set; }
    }
}