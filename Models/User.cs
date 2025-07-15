using System.Collections.Generic;

namespace InvenTrack.Api.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required byte[] PasswordHash { get; set; }
        public required byte[] PasswordSalt { get; set; }

        // Properti navigasi untuk transaksi yang dilakukan oleh pengguna ini
        public required ICollection<Transaction> Transactions { get; set; }
    }
}