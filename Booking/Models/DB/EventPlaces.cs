using System;
using System.Collections.Generic;

namespace Booking.Models.DB
{
    public partial class EventPlaces
    {
        public EventPlaces()
        {
            CartDetails = new HashSet<CartDetails>();
            Sale = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public int EventId { get; set; }
        public int Row { get; set; }
        public string PlaceNumber { get; set; }
        public bool IsAvailable { get; set; }

        public virtual Events Event { get; set; }
        public virtual ICollection<CartDetails> CartDetails { get; set; }
        public virtual ICollection<Sale> Sale { get; set; }
    }
}
