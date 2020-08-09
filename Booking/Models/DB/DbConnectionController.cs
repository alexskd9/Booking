using Microsoft.AspNetCore.Mvc;

namespace Booking.Models.DB
{
    public class DbConnectionController : Controller
    {
        private BookingContext _db { get; set; }
        protected BookingContext db
        {
            get
            {
                if (_db == null)
                {
                    _db = new BookingContext();
                }

                return _db;
            }
        }
    }
}
