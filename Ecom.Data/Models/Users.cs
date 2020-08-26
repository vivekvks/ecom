using System.Collections.Generic;

namespace Ecom.Data.Models
{
    public partial class Users
    {
        public Users()
        {
            ProductListing = new HashSet<ProductListing>();
            UserRoles = new HashSet<UserRoles>();
        }

        public int UserId { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<ProductListing> ProductListing { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
