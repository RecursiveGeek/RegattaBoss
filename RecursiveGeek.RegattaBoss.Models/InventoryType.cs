using System;
using System.Collections.Generic;

namespace RecursiveGeek.RegattaBoss.Models
{
    public class InventoryType
    {
        public int InventoryTypeId { get; set; }
        public string ItemTypeCode { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }

        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime Modified => Updated ?? Created;

        public List<InventoryQuestion> InventoryQuestions { get; set; } // all of the Inventory Questions that are associated with this Inventory Type
        public List<InventoryItem> InventoryItems { get; set; } // all of the Inventory Items that use this Inventory Type
    }
}
