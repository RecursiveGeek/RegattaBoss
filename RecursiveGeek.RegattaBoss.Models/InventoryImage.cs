using System;

namespace RecursiveGeek.RegattaBoss.Models
{
    public class InventoryImage
    {
        public int InventoryImageId { get; set; }
        public byte[] FullImage { get; set; }

        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime Modified => Updated ?? Created;

        public InventoryItem InventoryItem { get; set; } // parent reference
    }
}
