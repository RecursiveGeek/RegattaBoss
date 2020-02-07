namespace RecursiveGeek.RegattaBoss.Models
{
    public class CartItemQuestion
    {
        public int CartItemQuestionId { get; set; }
        public string Answer { get; set; } // answer to the associated Inventory Question and Cart Item

        // the Inventory Question for the given Cart Item 
        public CartItem CartItem { get; set; } 
        public InventoryQuestion InventoryQuestion { get; set; }
    }
}
