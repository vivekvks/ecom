using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Authentication
{
    public class TokenData
    {
        public int UserId { get; set; }
        public int RoleTypeId { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
    }
}
