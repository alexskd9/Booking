using Booking.Models.DB;
using System.Collections.Generic;

namespace Booking.Models
{
    public class EventExtended
    {
        public Events Events { get; set; }
        public IEnumerable<EventPlaces> EventPlaces { get; set; }
    }
}
