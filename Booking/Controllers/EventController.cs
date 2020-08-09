using System;
using System.Linq;
using Booking.Models;
using Booking.Models.DB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{
    //ღონისძიებების და დეტალების დათვალიერება შეუძლიათ როგორც დალოგინებულ მომხმარებლებს, ასევე სტუმრებს
    [AllowAnonymous]
    public class EventController : DbConnectionController
    {
        public IActionResult AllEvents()
        {
            return View(db.Events.Where(x => x.EventDate >= DateTime.Today).OrderByDescending(x => x.EventDate).ToList());
        }

        public IActionResult Details(int id)
        {
            ViewBag.RowNumber = db.EventPlaces.Max(x=>x.Row);
            var eventInfo = db.Events.FirstOrDefault(x => x.Id == id);
            return View(new EventExtended()
            {
                Events = eventInfo,
                EventPlaces = db.EventPlaces.Where(x => x.EventId == eventInfo.Id).OrderBy(x=>x.Id)
            });
        }
    }
}
