using System;
using System.Collections.Generic;

namespace RecursiveGeek.RegattaBoss.Models.Table
{
    public class InvItem
    {
        public Guid Id { get; set; }
        public string ItemCode { get; set; }
        public InvItemType ItemType { get; set; }
        public string Description { get; set; }
        public float UnitPrice { get; set; }
        public bool IsActive { get; set; }
        public byte[] ThumbnailImage { get; set; }
        public List<InvItemImage> FullImages { get; set; }
        public string Notes { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime Modified => Updated ?? Created;
        
    }
}
