using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("AllEvents","Event");
        }
    }
}
