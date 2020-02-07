using System;
using System.Collections.Generic;

namespace RecursiveGeek.RegattaBoss.Models
{
    public class InventoryItem
    {
        public int InventoryItemId { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public float UnitPrice { get; set; }
        public float UnitCost { get; set; }
        public bool IsTaxable { get; set; }
        public bool IsActive { get; set; }
        public byte[] ThumbnailImage { get; set; }
        public string Notes { get; set; }

        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime Modified => Updated ?? Created;

        public InventoryType ItemType { get; set; } // Parent Reference
        public List<InventoryImage> FullImages { get; set; } // All of the images associated with this Inventory Item
    }
}
