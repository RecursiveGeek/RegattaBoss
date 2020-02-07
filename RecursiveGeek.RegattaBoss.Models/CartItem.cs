using System;

namespace RecursiveGeek.RegattaBoss.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public float UnitNetPrice { get; set; }
        public float Quantity { get; set; }
        public bool IsTaxable { get; set; }
        public float ExtendedNetPrice => UnitNetPrice * Quantity;
        public string Description { get; set; }

        public InventoryItem InventoryItem { get; set; } // assocated Inventory Item to this Cart Item
    }
}
