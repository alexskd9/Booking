using System.ComponentModel.DataAnnotations;

namespace Booking.Models.Account
{
    public class Login
    {
        [Required(ErrorMessage = "შეიყვანეთ ელ. ფოსტა")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "შეიყვანეთ პაროლი")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
