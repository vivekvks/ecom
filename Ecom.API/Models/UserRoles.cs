using System;
using System.Collections.Generic;

namespace Ecom.API.Models
{
    public partial class UserRoles
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }

        public virtual Users User { get; set; }
    }
}
