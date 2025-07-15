using System.Collections.Generic;

namespace InvenTrack.Api.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        // Properti navigasi untuk semua item dalam kategori ini
        public ICollection<Item>? Items { get; set; }
    }
}