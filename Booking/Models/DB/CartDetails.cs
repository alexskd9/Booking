using System;
using System.Collections.Generic;

namespace Booking.Models.DB
{
    public partial class CartDetails
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int EventId { get; set; }
        public int PlaceId { get; set; }
        public DateTime AdditionDate { get; set; }

        public virtual UserCarts Cart { get; set; }
        public virtual Events Event { get; set; }
        public virtual EventPlaces Place { get; set; }
    }
}
