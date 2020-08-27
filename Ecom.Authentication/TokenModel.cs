using Ecom.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Authentication
{
    public class TokenData
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public RoleType RoleTypeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsRegistrationCompleted { get; set; }
    }
}
