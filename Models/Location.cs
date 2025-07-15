using System.Collections.Generic;

namespace InvenTrack.Api.Models
{
    public class Location
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        // Properti navigasi untuk semua item di lokasi ini
        public required ICollection<Item> Items { get; set; }
    }
}