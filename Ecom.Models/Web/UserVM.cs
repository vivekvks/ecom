using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ecom.Models.Web
{
    public class UserVM
    {
        [Required]
        [MinLength(8)]
        public string Password { get; set; }

        [Required]
        public string UserName { get; set; }

        public bool IsEmail { get; set; } = false;

    }
}
