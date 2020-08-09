using System;
using System.Collections.Generic;

namespace Booking.Models.DB
{
    public partial class Sale
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public int DocNumber { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public int CartId { get; set; }
        public int PlaceId { get; set; }
        public decimal Price { get; set; }

        public virtual UserCarts Cart { get; set; }
        public virtual Events Event { get; set; }
        public virtual EventPlaces Place { get; set; }
        public virtual Users User { get; set; }
    }
}
