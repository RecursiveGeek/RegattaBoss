using System;

namespace RecursiveGeek.RegattaBoss.Models
{
    public class InventoryQuestion
    {
        public int InventoryQuestionId { get; set; }
        public string QuestionCode { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime Modified => Updated ?? Created;

        public InventoryType ItemType { get; set; } // parent reference
    }
}
