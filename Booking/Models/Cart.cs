namespace Booking.Models
{
    public class Cart
    {
        public int CartDetailsId { get; set; }
        public int EventId { get; set; }
        public string EventName { get; set; }
        public decimal Price { get; set; }
        public int PlaceId { get; set; }
        public int RowNumber { get; set; }
        public string PlaceNumber { get; set; }
    }
}
