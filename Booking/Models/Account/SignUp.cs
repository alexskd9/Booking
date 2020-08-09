using System;
using System.ComponentModel.DataAnnotations;

namespace Booking.Models.Account
{
    public class SignUp
    {
        [Required(ErrorMessage = "აუცილებელი ველია")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "აუცილებელი ველია")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "აუცილებელი ველია")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "აუცილებელი ველია")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "უნდა ჰქონდეს ელ. ფოსტის ფორმატი")]
        public string Email { get; set; }

        [Required(ErrorMessage = "აუცილებელი ველია")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "პაროლში უნდა გამოიყენოთ მინიმუმ ერთი დიდი ასო, ერთი ციფრი და ერთი სიმბოლო; პაროლის მინიმალური სიგრძე - 8 სიმბოლო")]
        public string Password { get; set; }

        [Required(ErrorMessage = "აუცილებელი ველია")]
        [Compare("Password", ErrorMessage = "პაროლები არ ემთხვევა")]
        public string RepeatPassword { get; set; }
    }
}
