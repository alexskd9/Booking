using System;
using System.Collections.Generic;

namespace Booking.Models.DB
{
    public partial class UserCarts
    {
        public UserCarts()
        {
            CartDetails = new HashSet<CartDetails>();
            Sale = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal Amount { get; set; }
        public bool? IsClosed { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<CartDetails> CartDetails { get; set; }
        public virtual ICollection<Sale> Sale { get; set; }
    }
}
