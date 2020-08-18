using System;
using System.Collections.Generic;

namespace Ecom.API.Models
{
    public partial class Users
    {
        public Users()
        {
            ProductListing = new HashSet<ProductListing>();
            QuestionMaster = new HashSet<QuestionMaster>();
            ReviewMaster = new HashSet<ReviewMaster>();
            UserRoles = new HashSet<UserRoles>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<ProductListing> ProductListing { get; set; }
        public virtual ICollection<QuestionMaster> QuestionMaster { get; set; }
        public virtual ICollection<ReviewMaster> ReviewMaster { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
