using System;
using System.Collections.Generic;

namespace RecursiveGeek.RegattaBoss.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public Guid OrderNumber { get; set; } = new Guid();
        public string AccountReference { get; set; } // account reference for the authentication provider
        public string AuthenticationProvider { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ShipToAddress1 { get; set; }
        public string ShipToAddress2 { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToState { get; set; }
        public string ShipToPostal { get; set; }
        public string BillToAddress1 { get; set; }
        public string BillToAddress2 { get; set; }
        public string BillToCity { get; set; }
        public string BillToState { get; set; }
        public string BillToPostal { get; set; }

        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime Modified => Updated ?? Created;

        public List<CartItem> CartItems { get; } = new List<CartItem>();
    }
}
