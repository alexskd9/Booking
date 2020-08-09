using System;
using System.Collections.Generic;

namespace Booking.Models.DB
{
    public partial class Users
    {
        public Users()
        {
            Sale = new HashSet<Sale>();
            UserCarts = new HashSet<UserCarts>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime LastEditionDate { get; set; }

        public virtual ICollection<Sale> Sale { get; set; }
        public virtual ICollection<UserCarts> UserCarts { get; set; }
    }
}
