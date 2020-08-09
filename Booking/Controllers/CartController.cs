using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Transactions;
using Booking.Models;
using Booking.Models.DB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Booking.Controllers
{
    //რაც შეეხება მომხმარებლის კალათს, მასთან მუშაობისას მომხმარებელი აუცილებლად უნდა იყოს დალოგინებული
    [Authorize]
    public class CartController : DbConnectionController
    {
        //კალათაში არსებული ბილეთების ნახვა
        public IActionResult Cart()
        {
            int userId = GetUserId();
            var userCart = db.UserCarts.FirstOrDefault(x => x.UserId == userId && x.IsClosed == null);
            if (userCart != null)
            {
                var cart = db.CartDetails.Where(x => x.CartId == userCart.Id).Select(x => new Cart()
                {
                    CartDetailsId = x.Id,
                    EventId = x.EventId,
                    EventName = x.Event.EventName,
                    RowNumber = x.Place.Row,
                    PlaceNumber = x.Place.PlaceNumber,
                    PlaceId = x.PlaceId,
                    Price = x.Event.TicketPrice
                });
                ViewBag.Amount = userCart.Amount;
                return View(cart);
            }
            else
            {
                return View();
            }
        }

        //კალათაში ახალი ბილეთის დამატება/დაჯავშნა (ბილეთების რაოდენობა იცვლება)
        public async Task<JsonResult> AddToCart(int eventId, int placeId)
        {
            var userid = GetUserId();
            var userCart = db.UserCarts.FirstOrDefault(x => x.UserId == userid && x.IsClosed == null);
            //თუ არსებობს გახსნილი კალათა, ჯავშანის დამატება ხდება მასში
            if (userCart != null)
            {
                var ticket = db.CartDetails.FirstOrDefault(x => x.EventId == eventId);
                db.CartDetails.Add(new CartDetails()
                {
                    CartId = userCart.Id,
                    EventId = eventId,
                    PlaceId = placeId,
                    AdditionDate = DateTime.Now
                });

                userCart.Amount += db.Events.FirstOrDefault(x => x.Id == eventId).TicketPrice;
                await db.SaveChangesAsync();
            }
            //სხვა შემთხვევაში ჯერ იქმნება ახალი კალათა და შედგომ ემატება ბილეთები
            else
            {
                var newCart = db.UserCarts.Add(new UserCarts()
                {
                    UserId = userid,
                    Amount = 0,
                    CreationDate = DateTime.Now
                });
                await db.SaveChangesAsync();

                db.CartDetails.Add(new CartDetails()
                {
                    CartId = db.UserCarts.FirstOrDefault(x => x.UserId == userid && x.IsClosed == null).Id,
                    EventId = eventId,
                    PlaceId = placeId,
                    AdditionDate = DateTime.Now
                });

                var cart = db.UserCarts.FirstOrDefault(x => x.UserId == userid && x.IsClosed == null);
                cart.Amount = db.Events.FirstOrDefault(x => x.Id == eventId).TicketPrice;
                await db.SaveChangesAsync();
            }
            await db.SaveChangesAsync();
            var place = db.EventPlaces.FirstOrDefault(x => x.Id == placeId);
            place.IsAvailable = false;
            await db.SaveChangesAsync();
            return Json("");
        }

        //კალათიდან ბილეთების წაშლა
        [HttpPost]
        public async Task<JsonResult> RemoveFromCart(int cartDetailsId, int placeId)
        {
            var userId = GetUserId();
            var cartEvent = db.CartDetails.FirstOrDefault(x => x.Id == cartDetailsId && x.PlaceId == placeId);
            var eventId = db.Events.FirstOrDefault(x => x.Id == cartEvent.EventId);
            var cart = db.UserCarts.FirstOrDefault(x => x.UserId == userId && x.IsClosed == null);

            cart.Amount -= eventId.TicketPrice;
            await db.SaveChangesAsync();

            db.CartDetails.Remove(cartEvent);
            await db.SaveChangesAsync();

            var returnedPlace = db.EventPlaces.FirstOrDefault(x => x.Id == placeId);
            returnedPlace.IsAvailable = true;
            await db.SaveChangesAsync();

            return Json("");
        }

        //მონაცემთა შემოწმების გვერდზე გადასვლა
        public IActionResult Purchase()
        {
            decimal sum = 0;
            int userId = db.Users.FirstOrDefault(x => x.Email == User.Identity.Name).Id;
            var cart = db.UserCarts.FirstOrDefault(x => x.UserId == userId && x.IsClosed == null);
            sum = cart.Amount;


            PurchaseClass pc = new PurchaseClass()
            {
                UserID = userId,
                FirstName = db.Users.FirstOrDefault(x => x.Id == userId).FirstName,
                LastName = db.Users.FirstOrDefault(x => x.Id == userId).LastName,
                TotalAmount = sum
            };
            return View(pc);
        }

        //ბილეთების შეძენა
        [HttpPost]
        public IActionResult Purchase(Sale sale)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int userId = db.Users.FirstOrDefault(x => x.Email == User.Identity.Name).Id;
                var cartid = db.UserCarts.FirstOrDefault(x => x.UserId == userId && x.IsClosed == null).Id;
                var userCart = db.CartDetails.Where(x => x.CartId == db.UserCarts.FirstOrDefault(x => x.UserId == userId && x.IsClosed == null).Id);
                var lastDocNum = db.Sale.Select(x => x.DocNumber).ToList();

                if (lastDocNum.Count == 0)
                {
                    sale.DocNumber = 1;
                }
                else
                {
                    sale.DocNumber = lastDocNum.Last() + 1;
                }

                if (userCart != null)
                {
                    var cart = userCart.Select(x => new Cart()
                    {
                        CartDetailsId = x.Id,
                        EventId = x.EventId,
                        EventName = x.Event.EventName,
                        PlaceNumber = x.Place.PlaceNumber,
                        PlaceId = x.PlaceId,
                        Price = x.Event.TicketPrice
                    });
                    
                    //Sale ცხრილში მონაცემების გადატანა და უნიკალური Id-ის მინიჭება
                    foreach (var item in cart)
                    {
                    x1: string id = Guid.NewGuid().ToString("n").Substring(0, 32);
                        if (!db.Sale.Select(x => x.Id).Contains(id))
                        {
                            sale.Id = id;
                        }
                        else
                        {
                            goto x1;
                        }
                        sale.UserId = userId;
                        sale.EventId = item.EventId;
                        sale.CartId = cartid;
                        sale.PlaceId = item.PlaceId;
                        sale.Price = item.Price;
                        sale.Date = DateTime.Now;

                        db.Sale.Add(sale);
                        db.SaveChanges();
                    }
                }
                var userCartProduct = db.CartDetails.Where(x => x.CartId == cartid).Select(x => x.Id);

                //კალათის დეტალების გაწმენდა
                foreach (var item in userCartProduct)
                {
                    db.CartDetails.Remove(db.CartDetails.Find(item));
                }
                db.SaveChanges();

                //კალათის სტატუსის დახურვა
                var cartIsCompleted = db.UserCarts.FirstOrDefault(x => x.UserId == userId && x.IsClosed == null);
                cartIsCompleted.IsClosed = true;
                db.SaveChanges();
                transaction.Complete();
            }
            return RedirectToAction("Index", "Home");
        }

        //მომხმარებლის Id-ს მიღება
        public int GetUserId()
        {
            return db.Users.FirstOrDefault(x => x.Email == User.Identity.Name).Id;
        }
    }
}
