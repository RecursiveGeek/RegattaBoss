using System;

namespace RecursiveGeek.RegattaBoss.Models.Table
{
    public class CartItem
    {
        public Guid Id { get; set; }
        public Guid InvItemId { get; set; }
        public float NetPrice { get; set; }
    }
}
