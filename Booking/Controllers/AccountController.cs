using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Booking.Helpers;
using Booking.Models.DB;
using Booking.Models.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Booking.Controllers
{
    public class AccountController : DbConnectionController
    {
        //რეგისტრაცია
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUp user)
        {
            //მოწმდება, არის თუ არა ყველა ველი შევსებული
            if (ModelState.IsValid)
            {
                //ელ. ფოსტის უნიკალურობის შემოწმება
                var uniqueEmail = db.Users.Select(x => x.Email).ToList();
                //თუ ასეთი ფოსტა არ არის ბაზაში, ხდება ახალი მომხმარებლის რეგისტრაცია
                if (!uniqueEmail.Contains(user.Email))
                {
                    using (TransactionScope transaction = new TransactionScope())
                    {
                        db.Users.Add(new Users()
                        {
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            BirthDate = user.BirthDate,
                            Email = user.Email,
                            Password = Encryptor.SHA512Hash(user.Password),
                            CreationDate = DateTime.Now,
                            LastLoginDate = Convert.ToDateTime("1900 - 01 - 01 00:00:00.000"),
                            LastEditionDate = Convert.ToDateTime("1900 - 01 - 01 00:00:00.000")
                        });
                        await db.SaveChangesAsync();
                        transaction.Complete();
                    }
                }
                //თუ ასეთი ფოსტა არსებობს ბაზაში, გამოდის შესაბამისი შეცდომა
                else
                {
                    ViewBag.errorMsg = "ასეთი ელ. ფოსტა უკვე გამოიყენება";
                    return View();
                }
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

        //სისტემაში შესვლა
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login login, string returnUrl = "")
        {
            //პაროლის ჰეშირება
            string password = Encryptor.SHA512Hash(login.Password);
            //მომხმარებლის ძებნა ბაზაში
            var user = db.Users.FirstOrDefault(x => x.Email == login.Email);
            if (user != null)
            {
                //თუ პაროლი არასწორია, გამოდის შესაბამისი შეცდომა
                if (password != user.Password)
                {
                    if (login.Password != null)
                    {
                        ViewBag.errorPasswordMessage = "პაროლი მცდარია. სცადეთ კიდევ ერთელ";
                        return View();
                    }
                    ViewBag.errorPasswordMessage = "შეიყვანეთ პაროლი";
                    return View();
                }
                else
                {
                    await Authenticate(login.Email);
                    //ბოლო შესვლის თარიღი
                    user.LastLoginDate = DateTime.Now;
                    await db.SaveChangesAsync();
                    if (!String.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                        return Redirect(returnUrl);
                    else
                        return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                //თუ ელ. ფოსტა არასწორია, გამოდის შესაბამისი შეცდომა
                if (login.Email != null)
                {
                    ViewBag.errorLoginMessage = "ელ. ფოსტა არასწორია";
                    return View();
                }
                else
                {
                    return View();
                }
            }
        }        

        public async Task Authenticate(string userName)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        //სისტემიდან გასვლა
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}
