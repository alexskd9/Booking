using System;
using System.Collections.Generic;

namespace Booking.Models.DB
{
    public partial class Events
    {
        public Events()
        {
            CartDetails = new HashSet<CartDetails>();
            EventPlaces = new HashSet<EventPlaces>();
            Sale = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string EventDescription { get; set; }
        public decimal TicketPrice { get; set; }

        public virtual ICollection<CartDetails> CartDetails { get; set; }
        public virtual ICollection<EventPlaces> EventPlaces { get; set; }
        public virtual ICollection<Sale> Sale { get; set; }
    }
}
