using Ecom.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Models.Web.Response
{
    public class UserGetResponse
    {
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        internal string Password { get; set; }
        internal RoleType RoleId { get; set; } = RoleType.Admin;
    }
}
