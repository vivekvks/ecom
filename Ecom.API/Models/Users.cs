using System;
using System.Collections.Generic;

namespace Ecom.API.Models
{
    public partial class Users
    {
        

        public int Id { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }

    }
}
